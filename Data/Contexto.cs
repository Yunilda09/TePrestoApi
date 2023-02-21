using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TePrestoApi.Models;

namespace TePrestoApi.Data
{
    public class Contexto : DbContext
    {

        public DbSet<Ocupaciones> Ocupaciones => Set<Ocupaciones>();
        

        public  Contexto(DbContextOptions<Contexto> options)
            : base(options) { }

    }
}
