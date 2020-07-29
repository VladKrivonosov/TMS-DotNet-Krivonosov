using Homework_4.Enums;
using Homework_4.Interface;
using System;
using System.IO;

namespace Homework_4.Models
{
    class Animal : IAnimal
    {
        public readonly  Guid _animalID = Guid.NewGuid();

        public string AnimalName { get; set; }
        public string AnimaSekondName { get; set; } 
        public AnimalTypes TypeAnimal { get; set; }
        Guid IAnimal._animalID { set => throw new NotImplementedException(); }

        //TODO: почему AnimalFullName не работает
        public string AnimalFullName()
        {
            return $"{AnimalName} {AnimaSekondName}";
        }

        public Guid AnimalID()
        {
            return _animalID;
        }

        public void AnimalRename(string animalName)
        {
            AnimalName = animalName;
        }

        public Animal()
        {
        }

        public Animal(string animalName)
        {
            foreach (char c in animalName)
            {
                if (Char.IsNumber(c))
                {
                    throw new Exception("В имени не могут быть цифры"); 
                }
            }
            AnimalName = animalName;
        }

        public Animal(string animalName, string animaSekondName) : this(animalName)
        {
            foreach (char c in animaSekondName)
            {
                if (Char.IsNumber(c))
                {
                    throw new Exception("В имени не могут быть цифры");
                }
            }
            AnimaSekondName = animaSekondName;
        }

        public Animal(Guid animalID, string animalName, string animaSekondName, AnimalTypes types) : this(animalName, animaSekondName)
        {
            _animalID = animalID;
            TypeAnimal = types;
        }
    }
}
