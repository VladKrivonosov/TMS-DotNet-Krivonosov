using Homework_4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4.Managers
{
    class ZOOManager 
    {
        private readonly AnimalActions _animalActions;

        public List<Animal> animalList = new List<Animal>();

        public ZOOManager()
        {
            _animalActions = new AnimalActions();
        }

        public void AddAnimal(Animal animal)
        {
            animalList.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animalList.Remove(animal);
        }

        public void InfoAnimal(Animal animal)
        {
            _animalActions.GetInfo(animal);
        }

        public void ListOfAllAnimal()
        {
            Console.WriteLine();
            if (animalList.Count > 0 )
            {
                foreach (var animal in animalList)
                {
                    InfoAnimal(animal);
                }
            }
            else
            {
                Console.WriteLine("Список животных пуст");
            }
        }

        public void SetAnimal(Animal animal)
        {
            animalList.Add(animal);
        }

        public Animal IdForSearch(Guid guid)
        {
            Animal IdForSearch = animalList.Find(u => u.AnimalID() == guid);

            return IdForSearch;
        }

        public void AnimalRenameName(Animal animal, string animalName)
        {
            animal.AnimalName = animalName;
        }

        public void AnimalRenameSecondName(Animal animal, string animaSekondName)
        {
            animal.AnimaSekondName = animaSekondName;
        }

        public void ChangeAnimalName(Animal animal)
        {
            Console.WriteLine("Введите новое имя");
            var name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name))
            {
                AnimalRenameName(animal, name);

                Console.WriteLine("Введите следующее имя");
                var secondName = Console.ReadLine();
                if (!string.IsNullOrEmpty(secondName))
                {
                    AnimalRenameSecondName(animal, secondName);
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("Введите следующее имя");
                var secondName = Console.ReadLine();
                if (string.IsNullOrEmpty(secondName))
                {
                    return;
                }
                else
                {
                    AnimalRenameSecondName(animal, secondName);
                }
            }
        }
    }
}
