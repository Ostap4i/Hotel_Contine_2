using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel.Entities
{
    public class Client
    {
        public Client(int id, string full_Name,
            string age, string number_room,
            string date_of_arrival, string departure_date,
            string payment) 
        {
            Id = id;
            Full_Name = full_Name;
            Age = age;
            Number_room = number_room;
            DateOfArrival = date_of_arrival;
            DepartureDate = departure_date;
            Payment = payment;
        }

        public int Id { get; set; }
        public string Full_Name { get; set;}
        public string Age { get; set;}
        public string Number_room { get; set;}
        public string DateOfArrival { get; set;}
        public string DepartureDate { get; set;}
        public string Payment { get; set;}
    }
}
