using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class DogRepository : IDogRepository
    {
        private List<Dog> dogs { get; }

        public DogRepository()
        {
            dogs = new List<Dog>();
            dogs.Add(new Dog()
            {
                Id = 1,
                Name = "Woofi",
                Race = "Pitbull",
                YearOfBirth = DateTime.Now
            });
            dogs.Add(new Dog()
            {
                Id = 2,
                Name = "Mike",
                Race = "American Bulldog",
                YearOfBirth = DateTime.Now
            });
            dogs.Add(new Dog()
            {
                Id = 3,
                Name = "Rex",
                Race = "Azawakh",
                YearOfBirth = DateTime.Now
            });
        }

        public List<Dog> GetAllDogs()
        {
            return dogs.ToList();
        }
        public StringBuilder PrintAllDogs()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Dog d in GetAllDogs())
            {
                sb.Append($"\n{d.ToString()}");
            }
            return sb;
        }
        public StringBuilder PrintDog(int id)
        {
            StringBuilder sb = new StringBuilder();
            int foundDogIndex = dogs.FindIndex(dogToFind => dogToFind.Id == id);
            sb.Append($"\n{dogs[foundDogIndex].ToString()}");
            return sb;
        }
        public void AddDog(Dog dogToBeAdded)
        {
            List<int> dogIds = new List<int>();
            foreach (Dog existingDog in dogs)
            {
                dogIds.Add(existingDog.Id);
            }
            if (dogIds.Count != 0)
            {
                int start = dogIds.Max();
                dogToBeAdded.Id = start + 1;
            }
            else
            {
                dogToBeAdded.Id = 1;
            }
            dogs.Add(dogToBeAdded);
        }

        public Dog GetDog(int id)
        {
            foreach (Dog toBeEdittedDog in GetAllDogs())
            {
                if (toBeEdittedDog.Id == id)
                {
                    return toBeEdittedDog;
                }
            }

            return new Dog();
        }

        public void UpdateDog(Dog dogToBeUpdated)
        {
            if (dogToBeUpdated != null)
            {
                foreach (Dog existingDog in GetAllDogs())
                {
                    if (existingDog.Id == dogToBeUpdated.Id)
                    {
                        existingDog.Id = dogToBeUpdated.Id;
                        existingDog.Name = dogToBeUpdated.Name;
                        existingDog.Race = dogToBeUpdated.Race;
                        existingDog.YearOfBirth = dogToBeUpdated.YearOfBirth;
                    }
                }
            }
        }

        public void Delete(int id)
        {
            if (dogs != null && dogs.Count > 0)
            {
                int foundDogIndex = dogs.FindIndex(dogToFind => dogToFind.Id == id);
                dogs.RemoveAt(foundDogIndex);
            }
        }
    }
}
