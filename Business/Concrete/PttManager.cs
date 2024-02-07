using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager<T> : ISupplierService<T> 
        where T: class, IApplicant, new()
    {
        IApplicantService<T> _applicantService;

        public PttManager(IApplicantService<T> applicantService) //Constructor : new yapıldığında çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(T applicant)
        {
            if (_applicantService.CheckPerson(applicant))
            {
                Console.WriteLine(applicant.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(applicant.FirstName + " İÇİN MASKE VERİLEMEDİ.");
            }
        }
    }
}
