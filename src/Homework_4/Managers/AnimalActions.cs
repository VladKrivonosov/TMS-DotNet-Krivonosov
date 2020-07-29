using Homework_4.Enums;
using Homework_4.Interface;
using Homework_4.Models;
using System;

namespace Homework_4.Managers
{
    class AnimalActions : IAnimalActions, IAnimal
    {
        public string AnimalName { get; set; }
        public string AnimaSekondName { get; set; }
        public AnimalTypes TypeAnimal { get; set; }
        public Guid _animalID { set => throw new NotImplementedException(); }

        public string AnimalFullName()
        {
            return $"{AnimalName} {AnimaSekondName}";
        }

        public static void AnimalID (Animal animal)
        {
            animal.AnimalID();
        }

        public void GetInfo(Animal animal)
        {
            Console.WriteLine($"Класс: {animal.TypeAnimal}");
            Console.WriteLine($"Название: {animal.AnimalName} {animal.AnimaSekondName}");
            Console.WriteLine($"Идентификатор в базе: {animal.AnimalID()}\n");
        }

        public Animal CreateAnimal()
        {
            return new Animal();
        }

        public Animal CreateAnimal(string animalName)
        {
            return new Animal(animalName);
        }

        public Animal CreateAnimal(string animalName, string animaSekondName)
        {
            return new Animal(animalName, animaSekondName);
        }

        public Animal CreateAnimal(Guid animalID, string animalName, string animaSekondName, AnimalTypes TypeAnimal)
        {
            return new Animal(animalID, animalName, animaSekondName, TypeAnimal);
        }


    }
}
