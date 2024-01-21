using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_.Models;

    public class ProyectoFinal_Context : DbContext
    {
        public ProyectoFinal_Context (DbContextOptions<ProyectoFinal_Context> options)
            : base(options)
        {
        }

        public DbSet<ProyectoFinal_.Models.Empleado> Empleado { get; set; } = default!;

        public DbSet<ProyectoFinal_.Models.Sede>? Sede { get; set; }
    }
