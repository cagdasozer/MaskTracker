using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService<Person>
    {
        public void ApplyForMask(Person applicant)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person applicant)
        {
            //mernis kontrolü yapılacak kısım
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(applicant.NationalIdentity, applicant.FirstName, applicant.LastName, applicant.DateOfBirthday))).Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
