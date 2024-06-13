using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public interface IDogRepository
    {
        void AddDog(Dog dog);

        List<Dog> GetAllDogs();

        StringBuilder PrintAllDogs();
        StringBuilder PrintDog(int id);

        Dog GetDog(int id);

        void UpdateDog(Dog dog);

        void Delete(int id);
    }
}
