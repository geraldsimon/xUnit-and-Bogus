using System;

namespace Data.Fake
{
    class Program
    {
        static void Main(string[] args)
        {
            var clients = DataFakeClientes.GenerateClients(2);

            foreach (var client in clients)
            {
                Console.WriteLine(client.ID);
                Console.WriteLine(client.FirstName);
                Console.WriteLine(client.LastName);
                Console.WriteLine(client.Gender);
                Console.WriteLine(client.Birthday);
                Console.WriteLine(client.Phone);
                Console.WriteLine(client.Salary);
                Console.WriteLine(client.Email);
            }
        }
    }
}