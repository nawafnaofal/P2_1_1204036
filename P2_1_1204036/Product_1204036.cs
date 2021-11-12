using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204036
{
    public class Product_1204036
    {
        private string myType;
        private string myTitle;

        public Product_1204036()
        {
            
        }

        public Product_1204036(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }
        
        public string MyTitle
        {
            get
            {
                return myTitle;
            }

            set
            {
                myTitle = value;

            }
        }                          
    }
}




