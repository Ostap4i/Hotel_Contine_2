using Project_Hotel.Entities;
using Project_Hotel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel.Controllers
{
    public class ClientController
    {
        private ClientService clientService = new ClientService();

        public List<Client> getAllClients()
        {
            return clientService.getAllClients();
        }

        public int createNewClient(string Full_Name, string Age,
            string Number_room, string DateOfArrival, string DepartureDate, string Payment)
        {
            return clientService.createNewClient(Full_Name, Age, Number_room, DateOfArrival, DepartureDate, Payment);
        }

        public Client getClientById(int id)
        {
            return clientService.getClientById(id);
        }

        public void updateClient(int id, string Full_Name, string Age,
            string Number_room, string DateOfArrival, string DepartureDate, string Payment)
        {
            clientService.updateClient(id, Full_Name, Age, Number_room, DateOfArrival, DepartureDate, Payment);
        }

        public void deleteClient(int id)
        {
            clientService.deleteClient(id);
        }
    }
}
