﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204036
{
    public class DVD_1204036: Product_1204036
    {
        protected string duration;

        public DVD_1204036(string title, string duration)
        {
            this.MyTitle = title;
            this.duration = duration;
            this.MyType = "DVD";

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }
    }
}
