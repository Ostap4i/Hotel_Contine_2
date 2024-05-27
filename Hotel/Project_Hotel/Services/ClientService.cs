using Project_Hotel.Entities;
using Project_Hotel.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel.Services
{
    public class ClientService
    {
        string connectionString = "Server=tcp:ostapserver.database.windows.net,1433;" +
           "Initial Catalog=Testdb;Persist Security Info=False;User ID=CloudSA713bc2aa;Password=ITstep123;" +
           "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" +
           "Pooling=true; Max Pool Size=10; Min Pool Size=2";

        private ClientRepository clientRepository = new ClientRepository();
        public List<Client> getAllClients()
        {
            List<Client> clients = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    clients = clientRepository.getAllClients(connection);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return clients;
        }


        // Get Account by ID
        public Client getClientById(int id)
        {
            Client client = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    client = clientRepository.getClientById(connection, id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return client;
        }


        // Create new Account
        public int createNewClient(string Full_Name, string Age,
            string Number_room, string DateOfArrival, string DepartureDate, string Payment)
        {
            int id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    clientRepository.createNewClient(connection, Full_Name, Age, Number_room, DateOfArrival, DepartureDate, Payment);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return id;
        }


        // Update Client
        public void updateClient(int id, string Full_Name, string Age,
            string Number_room, string DateOfArrival, string DepartureDate, string Payment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                   Client client = clientRepository.getClientById(connection, id);
                    if (client != null)
                    {
                        clientRepository.updateClient(connection, id, Full_Name, Age, Number_room, DateOfArrival, DepartureDate, Payment);
                    }
                    else
                    {
                        throw new Exception("\t\tThis account not exist\n\n");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        // Delete Account
        public void deleteClient(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               Client client = clientRepository.getClientById(connection, id);
                if (client != null)
                {
                    clientRepository.deleteClient(connection, id);
                }
                else
                {
                    throw new Exception("\t\tThis client not exist\n\n");
                }
            }
        }
    }
}
