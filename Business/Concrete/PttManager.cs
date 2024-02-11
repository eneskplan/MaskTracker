using Business.Abstract;
using Entities.Concrete;

// NOT : Yeni bir özellik geldiğinde mevcut kodlara dokunmaman gerekiyor. Asla dokunma. Baştan ona göre kodla.
namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        // Constructor new yapıldığında çalışır.
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
         
        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            }
        }
    }
}
