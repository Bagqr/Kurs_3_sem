using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Курсовая_работа_за_3_семестр
{
    public class EmployeeService
    {
        private readonly DataManager<Employee> _manager;
        public List<Employee> Employees { get; }

        public EmployeeService(string filePath)
        {
            _manager = new DataManager<Employee>(filePath);
            Employees = _manager.LoadData() ?? new List<Employee>();
        }

        public void Update(Employee emp)
        {
            _manager.SaveData(Employees);
        }

        public IEnumerable<object> GetGridViewData()
            => Employees.Select(emp => new
            {
                ФИО = emp.FullName,
                Адрес = emp.Address,
                Должность = emp.Position,
                Оклад = $"{emp.Salary:N0} ₽",
                Надбавка = emp.Bonus.HasValue ? $"{emp.Bonus:N0} ₽" : "—",
                Оружие = emp.HasWeapon && emp.Weapon != null
                            ? $"{emp.Weapon.Model} ({emp.Weapon.RegistrationNumber})"
                            : "Нет",
                Спецсредства = emp.SpecialEquipment.Any()
                            ? string.Join(", ", emp.SpecialEquipment)
                            : "—",
                Контракт = emp.AssignedContract?.Type.ToString() ?? "—"
            });
        public List<Employee> GetGuards()
        {
            return Employees.Where(e => e.Position == "Охранник").ToList();
        }
        public void SaveAll()
        {
            var json = JsonConvert.SerializeObject(Employees, Formatting.Indented);
            File.WriteAllText("employees.json", json);
        }

    }

}
