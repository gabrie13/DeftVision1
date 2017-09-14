using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Deft1.Models;

namespace Deft1.Services
{
    interface IPositionService
    {
        List<PositionViewModel> GetAll();
    }
}
