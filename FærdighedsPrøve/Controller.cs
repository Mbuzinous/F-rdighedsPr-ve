using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class Controller
    {
        IDogRepository _dogRepo;
        IMemeberRepository _memeberRepo;

        public Member Member { get; set; }
        public Dog Dog { get; set; }
        public Controller(IDogRepository dogRepository, IMemeberRepository memeberRepo) 
        {
            _dogRepo = dogRepository;
            _memeberRepo = memeberRepo;
        }

        public void GetMember(int id)
        {
            Member = _memeberRepo.GetMember(id);
        }

        public void GetDog(int id)
        {
            Dog = _dogRepo.GetDog(id);
        }

        public StringBuilder DisplayMember(int id)
        {
            return _memeberRepo.PrintMember(id);

        }
        public StringBuilder DisplayDog(int id)
        {
            return _dogRepo.PrintDog(id);

        }

        public void AssignDog()
        {
            Member.RegisterDog(Dog);
        }

        public int DisplayAge()
        {
            return Member.CalculateAge();
        }
    }
}
