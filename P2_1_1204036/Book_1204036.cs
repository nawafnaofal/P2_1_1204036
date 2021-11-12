using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204036
{
    public class Book_1204036: Product_1204036
    {
        protected string pageCount;
        
        public Book_1204036(string type, string title, string pagecount) 
            : base(type, title)
        {
            this.pageCount = pagecount;
        }
        
        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
    }
}
