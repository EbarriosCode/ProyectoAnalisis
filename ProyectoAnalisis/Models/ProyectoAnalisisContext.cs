using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BankSystem.Models;

namespace ProyectoAnalisis.Models
{
    public class ProyectoAnalisisContext : DbContext
    {       
        public ProyectoAnalisisContext() : base("ProyectoAnalisisContext")
        {
        }

        public DbSet<CobroDocumento> CobroDocumentoes { get; set; }

        public DbSet<CuentaBancaria> CuentaBancarias { get; set; }
    }
}
