using Microsoft.EntityFrameworkCore;
using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prestamos> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = JMP-PC\SQLEXPRESS; DataBase = Parcial; Trusted_Connection = true");
        }
    }
}
