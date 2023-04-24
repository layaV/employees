using AutoMapper;
using Bogus;
using ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public interface IPersonService
    {
        PersonDTO GetRandomPerson();
    }

    

}
