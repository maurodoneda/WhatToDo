using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WhatToDo.Models;

namespace WhatToDo.Data
{
    public class WhatToDoContext : DbContext
    {
        public WhatToDoContext (DbContextOptions<WhatToDoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDo { get; set; }
    }
}
