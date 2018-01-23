using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIEDL20172018.Models
{
    public class Client
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
            set { firstname = value; }
        }

        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public Double Money
        {
            get { return money; }
            set { money = value; }
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
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
