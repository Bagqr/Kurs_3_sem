using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_за_3_семестр
{
    public abstract class Client
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public List<Contract> Contracts { get; set; }

        public Client()
        {
            Contracts = new List<Contract>();
        }
    }

    public class LegalEntity : Client
    {
        public string CompanyName { get; set; }

        public LegalEntity(string id, string address, string companyName)
        {
            Id = id;
            Address = address;
            CompanyName = companyName;
        }
    }

    public class Individual : Client
    {
        public string FullName { get; set; }
        public string PassportData { get; set; }

        public Individual(string id, string address, string fullName, string passportData)
        {
            Id = id;
            Address = address;
            FullName = fullName;
            PassportData = passportData;
        }
    }

    public class Contract
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ContractType Type { get; set; }
        public decimal Amount { get; set; }
        public List<Payment> Payments { get; set; } = new List<Payment>();

        public int RequiredGuardCount { get; set; } // Сколько охранников нужно
        public List<string> AssignedGuardIds { get; set; } = new List<string>();
        public List<Employee> AssignedGuards { get; set; } = new List<Employee>();
        public string ObjectAddress { get; set; } // для охраны объекта
        public DateTime? EventDate { get; set; }  // для разовых мероприятий
        public int Hours { get; set; }            // длительность в часах
        public int GuardCount { get; set; }       // количество охранников
        public string Description { get; set; }   // причина/описание
        public ContractType ContractType { get; set; } // "Разовый" или "Постоянный"
        public Client Client { get; set; } // Ссылка на клиента
        public int AssignedGuardCount => AssignedGuards?.Count ?? 0;

        public List<string> AssignedEmployeeIds { get; set; } = new List<string>();


    }

    public class Payment
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string DocumentNumber { get; set; }
    }

    public enum ContractType
    {
        Охрана_мероприятия,
        Охрана_объекта
    }

}
