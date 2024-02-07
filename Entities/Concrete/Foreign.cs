using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Foreign : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long ForeignNationalIdentity { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirth { get; set; }
    }
}
