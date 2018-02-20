using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModel.Models
{
    public class Client : ModelBase
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String firstname;
        private String lastname;
        private Double money;
        private List<Product> bag;
        #endregion

        #region Properties
        public String Firstname
        {
            get { return firstname; }
            set {
                firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        public String Lastname
        {
            get { return lastname; }
            set {
                lastname = value;
                OnPropertyChanged("Lastname");
            }
        }

        public Double Money
        {
            get { return money; }
            set {
                money = value;
                OnPropertyChanged("Money");
            }
        }

        public List<Product> Bag
        {
            get { return bag; }
            set { bag = value; }
        }
        #endregion

        #region Constructors
        public Client()
        {

        }

        public Client(string firstname, string lastname, double money)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.money = money;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion

    }
}
