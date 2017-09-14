using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Deft1.Models;
using System.Data.Entity;

namespace Deft1.Models
{
    public class DeftDbSetInitializer : DropCreateDatabaseAlways<DeftDB>
    {
        protected override void Seed(DeftDB context)
        {
            base.Seed(context);
        }
    }
}