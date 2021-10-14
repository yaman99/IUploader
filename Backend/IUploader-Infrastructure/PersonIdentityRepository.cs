using IUploader_Appilication.Interfaces;
using IUploader_Appilication.Interfaces.Repos;
using IUploader_Appilication.Models;
using IUploader_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUploader_Infrastructure
{
    public class PersonIdentityRepository : IPersonIdentityRepository
    {
        private readonly AppilicationDbContext _context;

        public PersonIdentityRepository(AppilicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PersonIdentity>> GetPersons()
        {
            var personIdentity = await _context.PersonIdentity.Where(x => x.Registration.Contains("جوبر")).Take(50).ToListAsync();

            return personIdentity;
        }
    }
}
