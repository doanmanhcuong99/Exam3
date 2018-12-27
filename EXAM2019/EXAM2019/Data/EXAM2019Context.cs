using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EXAM2019.Models
{
    public class EXAM2019Context : DbContext
    {
        public EXAM2019Context (DbContextOptions<EXAM2019Context> options)
            : base(options)
        {
        }

        public DbSet<EXAM2019.Models.Student> Student { get; set; }
    }
}
