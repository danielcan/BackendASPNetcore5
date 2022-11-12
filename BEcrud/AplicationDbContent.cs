using BEcrud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEcrud
{
    public class AplicationDbContent: DbContext
    {
        public DbSet<Comentario> Comentario { get; set; }

        public AplicationDbContent(DbContextOptions<AplicationDbContent> options) : base(options)
        {

        }


    }
}
