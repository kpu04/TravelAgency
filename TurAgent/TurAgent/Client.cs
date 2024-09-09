using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    public class Client
    {
        private string surname;
        private string name;
        private string patronymic;
        private string passportNumber;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public string PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }
    }
}
