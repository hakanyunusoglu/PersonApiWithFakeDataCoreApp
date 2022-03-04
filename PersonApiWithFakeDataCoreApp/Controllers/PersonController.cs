using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PersonApiWithFakeDataCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [Route("LoadPersonList")]
        public List<Person> LoadPersonList()
        {
            List<Person> resultlist = new List<Person>();
            for (int i = 1; i <= 100; i++)
            {
                Person person = new Person()
                {
                    PersonID = i,
                    PersonName = FakeData.NameData.GetFirstName(),
                    PersonSurname = FakeData.NameData.GetSurname(),
                    PersonEmail = FakeData.NetworkData.GetEmail(),
                    PersonAdress = FakeData.PlaceData.GetAddress(),
                    PersonCity = FakeData.PlaceData.GetCity(),
                    PersonCountry = FakeData.PlaceData.GetCountry()
                };
                resultlist.Add(person);
            }
            return resultlist;
        }
    }
}
