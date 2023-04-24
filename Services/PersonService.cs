using AutoMapper;
using Bogus;
using ConsoleApp.Model;
//using ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class PersonService : IPersonService
    {
        public PersonDTO GetRandomPerson()
        {
            var faker = new Faker();

            var person = new Model.Person
            {
                Id = faker.Random.Int(),
                FirstName = faker.Name.FirstName(),
                LastName = faker.Name.LastName(),
                Age = faker.Random.Int(18, 60),
                Address = new Address
                {
                    Street = faker.Address.StreetAddress(),
                    City = faker.Address.City(),
                    State = faker.Address.State(),
                    Pin = faker.Address.ZipCode()
                }
            };

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Model.Person, PersonDTO>();
                cfg.CreateMap<Address, AddressDTO>();
            }); 

            var mapper = config.CreateMapper();

            var personDto = mapper.Map<PersonDTO>(person);

            return personDto;
        }
    }
}
