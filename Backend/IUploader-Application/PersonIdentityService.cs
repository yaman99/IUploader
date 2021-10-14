using IUploader_Appilication.Interfaces;
using IUploader_Appilication.Interfaces.Repos;
using IUploader_Appilication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IUploader_Appilication
{
    public class PersonIdentityService : IPersonIdentityService
    {
        private readonly IPersonIdentityRepository _personIdentityRepository;
        public PersonIdentityService(IPersonIdentityRepository personIdentityRepository)
        {
            _personIdentityRepository = personIdentityRepository;
        }

        public async Task<List<PersonalIdentityModel>> GetPersons()
        {
            var data = await _personIdentityRepository.GetPersons();
            List<PersonalIdentityModel> personModel = new();
            Regex khaaWithNumber = new(@"([\u062E\u0640]+)(\d+)");
            Regex lettersWithNumbers = new(@"(?<char>[\u0621-\u064A\s]+)(?<num>\d+)");
            foreach (var item in data)
            {
                var itemString = item.Registration
                    .Split(",").FirstOrDefault()
                    .Replace(" خ ", " ")
                    .Replace("/", "")
                    .Replace(" - ", "")
                    .Replace(" ج ", "");

                if (khaaWithNumber.IsMatch(itemString))
                {
                    itemString = itemString.Replace("خ", "").Replace("ـ", "");
                }
                if (lettersWithNumbers.IsMatch(itemString))
                {
                    Match result = lettersWithNumbers.Match(itemString);
                    string alphaPart = result.Groups["char"].Value;
                    string numberPart = result.Groups["num"].Value;
                    personModel.Add(PrepareModel(item.Registration, item.RegistrationNo,  alphaPart, numberPart , true));
                }
                else
                {
                    personModel.Add(PrepareModel(item.Registration, item.RegistrationNo, itemString, item.RegistrationNo , false));
                }
                //personModel.Add(PrepareModel(itemString, item.RegistrationNo));

            }
            return personModel;
        }

        private static PersonalIdentityModel PrepareModel(string registration , string registrationNo , string cutomReg , string cutomRegNo , bool isMatched)
        {
            var model = new PersonalIdentityModel
            {
                Registration = registration,
                RegistrationNo = registrationNo,
                CustomReg = cutomReg,
                CustomRegNo = cutomRegNo,
                IsMatched = isMatched
            };
            return model;
        }
    }
}
