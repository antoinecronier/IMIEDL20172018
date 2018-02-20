using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModel.Models
{
    public class Product : ModelBase
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String name;
        private Double price;
        #endregion

        #region Properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Double Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Constructors
        public Product()
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
