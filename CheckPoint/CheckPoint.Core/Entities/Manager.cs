﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Entities
{
    public class Manager : User
    {public Manager() { }
       
        public Manager(int id, string userName, string email, string password) : base(id, userName, email, password)
        {
        }
    }
}
