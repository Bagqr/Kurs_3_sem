using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_за_3_семестр
{
    using System;
    using System.Collections.Generic;

    public class Employee
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public decimal? Bonus { get; set; } // Надбавка
        public bool HasWeapon { get; set; }
        public Weapon Weapon { get; set; }
        public List<string> SpecialEquipment { get; set; }
        public string LicenseNumber { get; set; }
        public string INN { get; set; }
        public string PFR { get; set; }
        public Schedule DutySchedule { get; set; }
        public Contract AssignedContract { get; set; } // Добавляем привязку

        public Employee()
        {
            SpecialEquipment = new List<string>();
            DutySchedule = new Schedule();
        }
    }
    public static class PositionSalaryMap
    {
        public static Dictionary<string, decimal> Salaries = new Dictionary<string, decimal>
    {
        { "Охранник", 50000 },
        { "Начальник охраны", 70000 },
        { "Инспектор", 60000 },
        { "Оператор видеонаблюдения", 45000 }
    };
    }

    public class Weapon
    {
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }

        public Weapon(string model, string registrationNumber)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
        }

    }
    public static class SpecialEquipmentList
    {
        public static List<string> Items = new List<string>
    {
        "Бронежилет",
        "Рация",
        "Резиновая дубинка",
        "Наручники",
        "Газовый баллончик"
    };
    }



    public class Schedule
    {
        public List<Shift> Shifts { get; set; } = new List<Shift>();
    }



    public class Shift
    {
        // Уникальный идентификатор смены
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // Дата начала суток дежурства
        public DateTime Date { get; set; }

        // Тип смены, например "Дневная" или "Ночная"
        public string Type { get; set; }

        // При необходимости замена
        public string ReplacementEmployeeId { get; set; }
        public string ReasonForReplacement { get; set; }
    }

}
