using FBTarjeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Clase que se usa para migrar datos al modelo.
 Crea una instancia de nuestra BD para que podamos editarla y crear consultas*/

namespace FBTarjeta
{
    public class AplicationDbContext: DbContext
    {

        public DbSet<TarjetaCredito> TarjetaCredito { set; get; } //aca se mapea nuestro modelo con la BD
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base (options)
        {

        }
    }
}
