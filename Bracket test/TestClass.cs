using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bracket_test
{
    class TestClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string this[string propName]
        {
            get
            {
                switch(propName)
                {
                    case "FirstName":
                        return this.FirstName;
                    case "LastName":
                        return this.LastName;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (propName)
                {
                    case "FirstName":
                        this.FirstName = value;
                        break;
                    case "LastName":
                        this.LastName = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }





    }
}
