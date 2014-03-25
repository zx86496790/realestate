using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Branch
    {
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private string postal;

        public string Postal
        {
            get { return postal; }
            set { postal = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string picture;

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Branch(string city,string street,string postal,string phone,string picture)
        {
            this.city=city;
            this.street = street;
            this.postal = postal;
            this.phone = phone;
            this.picture = picture;
            this.amount = 0;
        }
    }
}
