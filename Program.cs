using ConsoleApp.Services;
using Newtonsoft.Json;

var personService = new PersonService();
var person = personService.GetRandomPerson();

var json = JsonConvert.SerializeObject(person);
Console.WriteLine(json);
