using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudEntityFramekorkApi;

namespace CrudEntityFramekorkApi.Data
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext (DbContextOptions<UsuariosContext> options)
            : base(options)
        {
        }

        public DbSet<CrudEntityFramekorkApi.Usuario> Usuario { get; set; }
    }
}
