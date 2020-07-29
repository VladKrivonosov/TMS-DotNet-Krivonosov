using System.ComponentModel.DataAnnotations;

namespace Homework_4.Enums
{
    public enum AnimalTypes
    {
        Круглоротые = 1,
        [Display(Name = "Костные Рыбы")]
        КостныеРыбы = 2,
        Земноводные = 3,
        Пресмыкающиеся = 4,
        Птицы = 5,
        Млекопитающие = 6,
        Неопределен = 7
    }
}
