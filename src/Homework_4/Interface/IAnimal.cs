using Homework_4.Enums;
using Homework_4.Models;
using System;

namespace Homework_4.Interface
{
    interface IAnimal
    {
        public string AnimalName { get; set; }
        public string AnimaSekondName { get; set; }
        public AnimalTypes TypeAnimal { get; set; }

        public Guid _animalID { set; }
    }
}
