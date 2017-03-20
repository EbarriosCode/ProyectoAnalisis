using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaBancario.Models
{
    public class Contexto : DbContext
    {
        public Contexto(): base("ConexionDB")
        {
        }

        public DbSet<CobroDocumento> CobroDocumento { get; set; }
        public DbSet<CuentaBancaria> CuentaBancaria { get; set; }
    }
}