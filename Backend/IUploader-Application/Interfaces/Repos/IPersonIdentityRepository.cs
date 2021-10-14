using IUploader_Appilication.Models;
using IUploader_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUploader_Appilication.Interfaces.Repos
{
    public interface IPersonIdentityRepository
    {
        Task<List<PersonIdentity>> GetPersons();
    }
}
