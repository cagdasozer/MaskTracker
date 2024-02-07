using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService<T>
    {
        public void ApplyForMask(T applicant);

        List<T> GetList();

        bool CheckPerson(T applicant);
    }
}
