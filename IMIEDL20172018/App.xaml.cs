﻿using MySql.Data.Entity;
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
        }

        protected override void OnActivated(EventArgs e)
        {
            new Database.MySQL.Test();
            base.OnActivated(e);
        }
    }
}
