﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    public class User_sJob
    {
        public int ID { get; set; }
        public int UserId { get; set;}
        public  string Job { get; set; }

        public virtual User User { get; set; }
    }
}
