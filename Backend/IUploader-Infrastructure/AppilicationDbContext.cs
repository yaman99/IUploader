using IUploader_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUploader_Infrastructure
{
    public class AppilicationDbContext : DbContext
    {
        public AppilicationDbContext(DbContextOptions<AppilicationDbContext> options) : base(options)
        {
        }

        public DbSet<PersonIdentity> PersonIdentity {get; set;}
    }
}
