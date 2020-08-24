using Homework_4.Enums;
using Homework_4.Managers;
using Homework_4.Models;
using System;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        private static readonly AnimalActions _animalActions = new AnimalActions();
        private static readonly ZOOManager _zoo = new ZOOManager();

        public static void Menu()
        {
            Console.WriteLine("\n1. Показать список всех животных");
            Console.WriteLine("2. Показать информацию о животном");
            Console.WriteLine("3. Добваить новое животное");
            Console.WriteLine("4. Изменить данные");
            Console.WriteLine("5. Удалить животное из списка");
            Console.WriteLine("6. Завершить\n");
        }

        static async Task Main()
        {
            Console.WriteLine("Добро пожаловать в ZOO Manager v.1.0");
            await Task.Delay(700);

            while (true)
            {
                Menu();
                int.TryParse(Console.ReadLine(), out int InputFromUser);

                switch (InputFromUser)
                {
                    case 1:
                        Animal animal;
                        _zoo.ListOfAllAnimal();
                        break;

                    case 2:
                        if ((animal = FindAnimal()) != null)
                        {
                            _zoo.InfoAnimal(animal);
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        InputAnimal();
                        break;

                    case 4:
                        if ((animal = FindAnimal()) != null)
                        {
                            _zoo.ChangeAnimalName(animal);
                        }
                        break;

                    case 5:
                        if ((animal = FindAnimal()) != null)
                        {
                            _zoo.RemoveAnimal(animal);
                            Console.WriteLine("Животное было успешно удалено из зоопарка.");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Команды не существует");
                        break;
                }
            }
        }

        private static void InputAnimal()
        {
            Animal animal;
            Console.Write("\nВведите имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите полное имя: ");
            var nameSekond = Console.ReadLine();

            if (string.IsNullOrEmpty(name) & string.IsNullOrEmpty(nameSekond))
            {
                animal = _animalActions.CreateAnimal();
            }
            else if (string.IsNullOrEmpty(nameSekond))
            {
                animal = _animalActions.CreateAnimal(name);
            }
            else
            {
                animal = _animalActions.CreateAnimal(name, nameSekond);
            }

            Console.WriteLine("Выберите класс животного:" +
                "\n1.Круглоротые \n2.Костные Рыбы \n3.Земноводные \n4.Пресмыкающиеся \n5.Птицы \n6.Млекопитающие");
            int.TryParse(Console.ReadLine(), out int userInput);
            Console.WriteLine();

            switch (userInput)
            {
                case 1:
                    {
                        animal.TypeAnimal = AnimalTypes.Круглоротые;
                    }
                    break;
                case 2:
                    {
                        animal.TypeAnimal = AnimalTypes.КостныеРыбы;
                    }
                    break;
                case 3:
                    {
                        animal.TypeAnimal = AnimalTypes.Земноводные;
                        break;
                    }
                case 4:
                    {
                        animal.TypeAnimal = AnimalTypes.Пресмыкающиеся;
                        break;
                    }
                case 5:
                    {
                        animal.TypeAnimal = AnimalTypes.Птицы;
                        break;
                    }
                case 6:
                    {
                        animal.TypeAnimal = AnimalTypes.Млекопитающие;
                        break;
                    }
                default:
                    {
                        animal.TypeAnimal = AnimalTypes.Неопределен;
                        break;
                    }
            }

            if (animal.AnimalName == string.Empty & animal.AnimaSekondName == string.Empty)
            {
                Console.WriteLine("Уточните данные");
            }
            else if (string.IsNullOrEmpty(animal.AnimalName) & string.IsNullOrEmpty(animal.AnimaSekondName) & userInput == default)
            {
                Console.WriteLine("Уточните данные");
            }
            else if ((string.IsNullOrEmpty(animal.AnimalName) & userInput == default) || (string.IsNullOrEmpty(animal.AnimaSekondName) & userInput == default))
            {
                Console.WriteLine("Уточните данные");
            }
            else
            {
                _zoo.SetAnimal(animal);
                Console.WriteLine("Животное успешно создано и добавлено в зоопарк!");
            }
        }

        private static Animal FindAnimal()
        {
            Animal animal;
            Console.WriteLine("\nВведите ID животного: ");
            var SearchQuery = Console.ReadLine();

            if (Guid.TryParse((SearchQuery), out Guid guid) & (animal = _zoo.IdForSearch(guid)) != null)
            {
                return animal;
            }
            else
            {
                Console.WriteLine("Животное с таким ID не найдено");
                return null;
            }
        }
    }
}
