using ProjectModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.MySQL
{
    public class Test
    {
        public Test()
        {
            MySQLManager<Client> clientManager = new MySQLManager<Client>();
            Client client1 = new Client("toto", "test", 12);
            Client client2 = new Client("tata", "test", 22);
            clientManager.Insert(client1);
            clientManager.Insert(client2);

            MySQLManager<Product> productManager = new MySQLManager<Product>();
        }
    }
}
