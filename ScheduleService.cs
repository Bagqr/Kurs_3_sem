using System;
using System.Collections.Generic;

namespace Курсовая_работа_за_3_семестр
{
    public class ScheduleService
    {
        private readonly EmployeeService _employeeService;

        public ScheduleService(EmployeeService employeeService)
        {
            if (employeeService == null)
                throw new ArgumentNullException(nameof(employeeService));
            _employeeService = employeeService;
        }

        /// <summary>
        /// Добавляет в расписание нового сотрудника смену, проверяя, 
        /// что в его списке нет другой смены с той же датой и типом.
        /// Сразу же сохраняет всех сотрудников в файл.
        /// </summary>
        public void AssignShift(Employee employee, Shift newShift)
        {
            if (employee == null)
                throw new ArgumentNullException("employee");
            if (newShift == null)
                throw new ArgumentNullException("newShift");

            // Убедимся, что у сотрудника есть Schedule
            if (employee.DutySchedule == null)
                employee.DutySchedule = new Schedule();

            // Проверка дублирования: ни одна существующая смена не должна совпадать
            foreach (Shift existing in employee.DutySchedule.Shifts)
            {
                if (existing.Date == newShift.Date && existing.Type == newShift.Type)
                {
                    throw new InvalidOperationException(
                        "Нельзя добавить две одинаковые смены (дата + тип).");
                }
            }

            // Добавляем новую смену
            employee.DutySchedule.Shifts.Add(newShift);

            // Сохраняем все изменения сотрудников в JSON
            _employeeService.SaveAll();
        }

        /// <summary>
        /// Удаляет смену по её уникальному идентификатору shiftId. 
        /// Ищет, у какого сотрудника она лежит, удаляет и сохраняет.
        /// </summary>
        public void DeleteShift(string shiftId)
        {
            if (string.IsNullOrEmpty(shiftId))
                throw new ArgumentNullException("shiftId");

            Employee owner = null;
            Shift toRemove = null;

            // Ищем, у кого есть смена с таким Id
            foreach (Employee emp in _employeeService.Employees)
            {
                if (emp.DutySchedule == null)
                    continue;

                foreach (Shift s in emp.DutySchedule.Shifts)
                {
                    if (s.Id == shiftId)
                    {
                        owner = emp;
                        toRemove = s;
                        break;
                    }
                }

                if (owner != null)
                    break;
            }

            if (owner == null || toRemove == null)
                throw new InvalidOperationException("Смена для удаления не найдена.");

            // Удаляем смену
            bool removed = owner.DutySchedule.Shifts.Remove(toRemove);
            if (!removed)
                throw new InvalidOperationException("Ошибка при удалении смены.");

            // Сохраняем все изменения сотрудников
            _employeeService.SaveAll();
        }
    }
}
