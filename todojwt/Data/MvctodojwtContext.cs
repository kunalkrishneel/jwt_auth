using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using todojwt.Models;

namespace todojwt.Data
{
    public class MvctodojwtContext : DbContext
    {
        public MvctodojwtContext (DbContextOptions<MvctodojwtContext> options)
            : base(options)
        {
        }

        public DbSet<todojwt.Models.UserModel> UserModel { get; set; } = default!;
    }
}
