using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Customer
    {
        public Customer(int id,string firstname,string lastname,double balance,int yearofbirth)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Balance = balance;
            this.YearofBirth = yearofbirth;
            CalculateAge();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        public int YearofBirth { get; set; }
        public int Age { get; set; }

        private void CalculateAge()
        {
            this.Age = DateTime.Now.Year - this.YearofBirth;
        }

    }
}
