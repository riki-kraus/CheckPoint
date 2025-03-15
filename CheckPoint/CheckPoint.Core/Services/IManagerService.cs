﻿using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Services
{
    public interface IManagerService
    {
        List<Manager> GetAll();

        Manager GetById(int id);

        void Add(Manager manager);


    }
}
