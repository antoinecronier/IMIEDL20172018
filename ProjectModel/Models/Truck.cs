using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModel.Models
{
    public class Truck : ModelBase
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int myVar1;

        public int MyProperty1
        {
            get { return myVar1; }
            set { myVar1 = value; }
        }

        private String myVar2;

        public String MyProperty2
        {
            get { return myVar2; }
            set { myVar2 = value; }
        }

    }
}
