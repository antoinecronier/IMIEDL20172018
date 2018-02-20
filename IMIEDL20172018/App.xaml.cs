using Database.MySQL;
using EntityUtils.Generator;
using MySql.Data.Entity;
using ProjectModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IMIEDL20172018
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            new Database.MySQL.Test();

            Task.Factory.StartNew(() =>
            {
                EntityGenerator<Client> generatorC = new EntityGenerator<Client>();
                EntityGenerator<Product> generatorP = new EntityGenerator<Product>();
                MySQLManager<Client> manager = new MySQLManager<Client>();
                for (int i = 0; i < 6000; i++)
                {
                    Client cli = generatorC.GenerateItem();
                    for (int j = 0; j < 4; j++)
                    {
                        cli.Bag.Add(generatorP.GenerateItem());
                    }
                    manager.Insert(cli);
                }
            });
        }
    }
}
