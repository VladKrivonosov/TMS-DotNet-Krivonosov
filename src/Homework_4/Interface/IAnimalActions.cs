using Homework_4.Models;
using System;

namespace Homework_4.Interface
{
    interface IAnimalActions : IAnimal
    {
        public void AnimalRename(Animal animal, string animalName)
        {
            AnimalName = animalName;
        }

        public void AnimalRename(Animal animal, string animalName, string animaSekondName)
        {
            AnimalName = animalName;
            AnimaSekondName = animaSekondName;
        }

        public void GetInfo(Animal animal);

        public string AnimalFullName();
    }
}
