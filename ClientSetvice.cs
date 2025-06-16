using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Курсовая_работа_за_3_семестр
{
    public class ClientService
    {
        private readonly DataManager<Client> _manager;
        public List<Individual> Individuals { get; }
        public List<LegalEntity> LegalEntities { get; }

        public ClientService(string filePath)
        {
            _manager = new DataManager<Client>(filePath);

            // Загружаем ВСЁ сразу — там будут и Individual, и LegalEntity
            var allClients = _manager.LoadData();

            // Разбиваем по конкретным типам
            Individuals = allClients.OfType<Individual>().ToList();
            LegalEntities = allClients.OfType<LegalEntity>().ToList();
        }

        /// <summary>
        /// Сохраняет обратно ВСЕх клиентов (и физ., и юр.), 
        /// чтобы при следующем запуске десериализация прошла корректно.
        /// </summary>
        public void SaveAll()
        {
            // Конкатенируем два списка в один IEnumerable<Client>
            var all = Individuals.Cast<Client>()
                        .Concat(LegalEntities);

            // Передаём в SaveData именно List<Client>, а не IEnumerable<Client>
            _manager.SaveData(all.ToList());
        }

        public IEnumerable<object> GetIndividualGrid()
            => Individuals.Select(i => new
            {
                ФИО = i.FullName,
                Паспорт = i.PassportData,
                Адрес = i.Address,
                КоличествоДоговоров = i.Contracts.Count
            });

        public IEnumerable<object> GetLegalEntityGrid()
            => LegalEntities.Select(e => new
            {
                Компания = e.CompanyName,
                Адрес = e.Address,
                КоличествоДоговоров = e.Contracts.Count
            });
    }
}
