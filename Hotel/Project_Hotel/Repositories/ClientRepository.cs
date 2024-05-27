using Project_Hotel.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hotel.Repositories
{
    public class ClientRepository
    {
        public List<Client> getAllClients(SqlConnection connection)
        {
            //Account account = new Account(1, "Dimon", "dimonch1k@gmail.com", "1234");

            List<Client> clients = new List<Client>();
            //accounts.Add(account);
            //return accounts;

            string query = "SELECT * FROM Clients";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string Full_Name = Convert.ToString(reader["full_Name"]);
                        string Age = Convert.ToString(reader["age"]);
                        string Number_room = Convert.ToString(reader["number_room"]);
                        string DateOfArrival = Convert.ToString(reader["date_of_arrival"]);
                        string DepartureDate = Convert.ToString(reader["departure_date"]);
                        string Payment = Convert.ToString(reader["payment"]);

                            Client client = new Client(id, Full_Name, Age, Number_room, DateOfArrival, DepartureDate, Payment);
                        clients.Add(client);
                    }
                }
            }
            return clients;
        }
        public Client getClientById(SqlConnection connection, int id)
        {
            Client client = null;
            string query = "SELECT * FROM Clients WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Full_Name = Convert.ToString(reader["Full_Name"]);
                        string Age = Convert.ToString(reader["age"]);
                        string Number_room = Convert.ToString(reader["number_room"]);
                        string DateOfArrival = Convert.ToString(reader["date_of_arrival"]);
                        string DepartureDate = Convert.ToString(reader["departure_date"]);
                        string Payment = Convert.ToString(reader["payment"]);

                        client = new Client(id, Full_Name, Age, Number_room, DateOfArrival, DepartureDate, Payment);
                    }
                }
            }
            return client;
        }

        public void createNewClient(SqlConnection connection, string Full_Name, string Age,
            string Number_room, string DateOfArrival, string vDepartureDate, string Payment)
        {
            string query = $"INSERT INTO Clients (full_Name, age, number_room, date_of_Arrival, departure_date, payment) output INSERTED.id " +
                $"VALUES (@full_Name, @age, @number_room, @date_of_Arrival, @departure_date, @payment)";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@full_Name", System.Data.SqlDbType.NVarChar).Value = Full_Name;
                cmd.Parameters.Add("@age", System.Data.SqlDbType.NVarChar).Value = Age;
                cmd.Parameters.Add("@number_room", System.Data.SqlDbType.NVarChar).Value = Number_room;
                cmd.Parameters.Add("@date_of_Arrival", System.Data.SqlDbType.NVarChar).Value = DateOfArrival;
                cmd.Parameters.Add("@departure_date", System.Data.SqlDbType.NVarChar).Value = vDepartureDate;
                cmd.Parameters.Add("@payment", System.Data.SqlDbType.NVarChar).Value = Payment;

                int id = (int)cmd.ExecuteScalar();
                Console.WriteLine("Inserted row with ID: " + id);
            }
        }


        public void updateClient(SqlConnection connection, int id, string Full_Name, string Age, string Number_room,
            string DateOfArrival, string DepartureDate, string Payment)
        {
            string query = $"UPDATE clients " +
                $"SET full_Name = @full_Name, age = @age , number_room = @number_room, dateOfArrival = @dateOfArrival,  dpartureDate = @departureDate, Payment = @payment " +
                $"WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@full_name", System.Data.SqlDbType.NVarChar).Value = Full_Name;
                cmd.Parameters.Add("@age", System.Data.SqlDbType.NVarChar).Value = Age;
                cmd.Parameters.Add("@number_room)", System.Data.SqlDbType.NVarChar).Value = Number_room;
                cmd.Parameters.Add("@dateOfArrival", System.Data.SqlDbType.NVarChar).Value = DateOfArrival;
                cmd.Parameters.Add("@departureDate", System.Data.SqlDbType.NVarChar).Value = DepartureDate;
                cmd.Parameters.Add("@payment", System.Data.SqlDbType.NVarChar).Value = Payment;
                cmd.ExecuteNonQuery();
                Console.WriteLine($"Client with ID {id} was successfully updated.");
            }
        }


        public void deleteClient(SqlConnection connection, int id)
        {
            string query = $"DELETE FROM Clients " +
                $"WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();
                Console.WriteLine($"Client with ID {id} was successfully deleted.");
            }
        }

        internal void createNewClient(string full_Name, string age, string number_room, string dateOfArrival, string departureDate, string payment, int v)
        {
            throw new NotImplementedException();
        }
    }
}



