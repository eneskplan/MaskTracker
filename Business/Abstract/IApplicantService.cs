using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // İnterface : Belli metot imzalarını barındırırlar , birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlar.
    public interface IApplicantService
    {
        // Maske için başvuru yapmak
        void ApplyForMask(Person person);

        // Person tipinde bir liste
        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}