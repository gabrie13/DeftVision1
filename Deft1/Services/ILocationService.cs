﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Deft1.Models;

namespace Deft1.Services
{
    interface ILocationService
    {
        List<LocationViewModel> GetAll();
        LocationViewModel FindById(int id);

        LocationViewModel Create(LocationViewModel location);
    }
}
