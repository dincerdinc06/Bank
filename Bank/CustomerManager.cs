using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    static class CustomerManager
    {
        public static void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" "+customer.LastName+ " Adlı Müşterinin Bilgileri Başarıyla Veri Tabanına Eklendi.");
        }

        public static void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Adlı Müşterinin Bilgileri Başarıyla Veri Tabanından Silindi.");
        }

        public static void CustomerUpdate(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Adlı Müşterinin Verileri Başarıyla Veri Tabanından Silindi ");
        }
    }
}
