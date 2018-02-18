using System;
using MyClassLibrary;

namespace ConsoleForLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int chooseMenu;
            Console.WriteLine("Меню программы" + "\n");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Журналы (добавить/листать/еще че-то)" + "\n");
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
            Console.WriteLine("2. Книги (добавить/читать/оставить отзыв)" + "\n");
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
            Console.WriteLine("3. Учебники (добавить/изучать/выкинуть)" + "\n");
            Console.WriteLine("========================================");
            Console.Write("Выберите нужный пункт: ");

            chooseMenu = Convert.ToInt32(Console.ReadLine());

            switch(chooseMenu)
            {
                case 1:
                    Magazine newMagazine = new Magazine();

                    Console.WriteLine("\nСначала добавим журнал\n");

                    Console.Write("Название журнала: ");
                    newMagazine.PublicationName = Console.ReadLine();

                    Console.Write("Месяц: ");
                    newMagazine.Month = Console.ReadLine();

                    Console.Write("Номер: ");
                    newMagazine.No = int.Parse(Console.ReadLine());

                    Console.Write("Кол-во страниц: ");
                    newMagazine.NumberOfPages = int.Parse(Console.ReadLine());

                    Console.Write("Издательство: ");
                    newMagazine.PublishingHouseName = Console.ReadLine();

                    Console.Write("Год: ");
                    newMagazine.PublishingYear = int.Parse(Console.ReadLine());

                    Console.Write("Тираж: ");
                    newMagazine.Edition = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n============Журнал добавлен!============\n\n");
                    newMagazine.ShowPrint();
                    Console.WriteLine("\n========================================");
                    newMagazine.FlipThrough();

                    break;

                case 2:

                    Book newBook = new Book();
                    Console.WriteLine("\nСначала добавим книгу\n");

                    Console.Write("Название книги: ");
                    newBook.PublicationName = Console.ReadLine();

                    Console.Write("Автор: ");
                    newBook.Author = Console.ReadLine();

                    Console.Write("Жанр: ");
                    newBook.Genre = Console.ReadLine();

                    Console.Write("Серия: ");
                    newBook.Seria = Console.ReadLine();

                    Console.Write("Язык: ");
                    newBook.Language = Console.ReadLine();

                    Console.Write("Переводчик: ");
                    newBook.Translator = Console.ReadLine();

                    Console.Write("Издательство: ");
                    newBook.PublishingHouseName = Console.ReadLine();

                    Console.Write("Год: ");
                    newBook.PublishingYear = int.Parse(Console.ReadLine());

                    Console.Write("Тираж: ");
                    newBook.Edition = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n============Книга добавлена!============\n\n");
                    newBook.ShowPrint();
                    Console.WriteLine("\n========================================");
                    Console.WriteLine("\nТеперь само чтение\n");
                    Console.WriteLine("========================================\n");
                    newBook.Read();
                    newBook.bookReview();

                    break;

                case 3:
                    ClassBook newClassBook = new ClassBook();
                    Console.WriteLine("\nСначала добавим учебник\n");

                    Console.Write("Учебник: ");
                    newClassBook.PublicationName = Console.ReadLine();

                    Console.Write("Предмет: ");
                    newClassBook.Subject = Console.ReadLine();

                    Console.Write("Класс: ");
                    newClassBook.Grade = int.Parse(Console.ReadLine());

                    Console.Write("Год: ");
                    newClassBook.PublishingYear = int.Parse(Console.ReadLine());

                    Console.Write("Издательство: ");
                    newClassBook.PublishingHouseName = Console.ReadLine();

                    Console.Write("Тираж: ");
                    newClassBook.Edition = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n============Учебник добавлен!============\n\n");
                    newClassBook.ShowPrint();
                    Console.WriteLine("\n========================================");

                    break;

                default:
                    Console.WriteLine("Вы ничего не выбрали или натупили. Конец программы.");
                    break;
            }
            

            Console.ReadKey();
        }
    }
}
