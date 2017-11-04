using Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datamodel
{
    public class CEISSContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
