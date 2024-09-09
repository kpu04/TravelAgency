using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    public class Tour
    {
        private string code;
        private string country;
        private string city;
        private string hotel;
        private string transportation;
        private string price;
        private string days;

        public Tour()
        {

        }
        public Tour(string code, string country, string city, string hotel, string transportation, string price, string days)
        {
            this.code = code;
            this.country = country;
            this.city = city;
            this.hotel = hotel;
            this.transportation = transportation;
            this.price = price;
            this.days = days;
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value != null)
                {
                    code = value;
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (value != null)
                {
                    country = value;
                }
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (value != null)
                {
                    city = value;
                }
            }
        }

        public string Transportation
        {
            get
            {
                return transportation;
            }
            set
            {
                if (value != null)
                {
                    transportation = value;
                }
            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value != null)
                {
                    price = value;
                }
            }
        }

        public string Days
        {
            get
            {
                return days;
            }
            set
            {
                if (value != null)
                {
                    days = value;
                }
            }
        }

        public string Hotel
        {
            get
            {
                return hotel;
            }
            set
            {
                if (value != null)
                {
                    hotel = value;
                }
            }
        }
    }
}
