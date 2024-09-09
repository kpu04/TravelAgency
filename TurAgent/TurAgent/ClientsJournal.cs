using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    public class ClientsJournal
    {
        Client client = new Client();
        private string tourCode;
        
        public ClientsJournal()
        {

        }

        public ClientsJournal(string surname, string name, string patronymic, string passportNumber, string tourCode)
        {
            client.Surname = surname;
            client.Name = name;
            client.Patronymic = patronymic;
            client.PassportNumber = passportNumber;
            this.tourCode = tourCode;
        }

        public Client Clients
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }
        public string TourCode
        {
            get { return tourCode; }
            set { tourCode = value; }
        }
    }
}
