using Business.Abstract;
using Entities.Concrete;
using MernisForeignServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService<Foreign>
    {
        public void ApplyForMask(Foreign applicant)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Foreign applicant)
        {
            KPSPublicYabanciDogrulaSoapClient client = new KPSPublicYabanciDogrulaSoapClient(KPSPublicYabanciDogrulaSoapClient.EndpointConfiguration.KPSPublicYabanciDogrulaSoap);

            return client.YabanciKimlikNoDogrulaAsync(new YabanciKimlikNoDogrulaRequest(new YabanciKimlikNoDogrulaRequestBody(applicant.ForeignNationalIdentity, applicant.FirstName, applicant.LastName, applicant.DateOfBirth))).Result.Body.YabanciKimlikNoDogrulaResult;

        }

        public List<Foreign> GetList()
        {
            throw new NotImplementedException();
        }
    }
}

