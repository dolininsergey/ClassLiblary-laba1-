using System;

//5. Журнал, книга, печатное издание, учебник.

namespace MyClassLibrary
{
    public abstract class Print
    {
        private int publishing_year;
        private int edition;

        public string PublicationName { get; set; }
        public string PublishingHouseName { get; set; }
        public int PublishingYear
        {
            get
            {
                return publishing_year;
            }
            set
            {
                if (value < 1900) publishing_year = 1900;
                else if (value > 2018) publishing_year = 2018;
                else publishing_year = value;
            }
        }
        public int Edition
        {
            get
            {
                return edition;
            }
            set
            {
                if (value < 1) edition = 1;
                else edition = value;
            }
        }

        public abstract void ShowPrint();
    }
       
    public class Magazine : Print
    {
        private int magazine_number;
        private int magazine_number_of_pages;

        public string Month { get; set; }

        public int No
        {
            get
            {
                return magazine_number;
            }
            set
            {
                if (value < 1) magazine_number = 1;
                else magazine_number = value;
            }
        }
        public int NumberOfPages
        {
            get
            {
                return magazine_number_of_pages;
            }
            set
            {
                if (value < 50) magazine_number_of_pages = 50;
                else if (value > 2000) magazine_number_of_pages = 2000;
                else magazine_number_of_pages = value;
            }
        }

        public void FlipThrough()
        {
            Console.Write("Листаю журнал " + PublicationName + "...");
            System.Threading.Thread.Sleep(1000);
            Console.Write("сплетни");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("...");
                Console.Write("ещё..");
                System.Threading.Thread.Sleep(1000);
                Console.Write("и ещё..");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Well Done! Полистали журнал " + PublicationName + "!");
        }

        public override void ShowPrint()
        {
            Console.WriteLine("Журнал: " + PublicationName + "\n");
            Console.WriteLine("Номер: " + No + "\n");
            Console.WriteLine("Месяц: " + Month + "\n");
            Console.WriteLine("Год: " + PublishingYear + "\n");
            Console.WriteLine("Издательство: " + PublishingHouseName + "\n");
            Console.WriteLine("Кол-во страниц: " + NumberOfPages + "\n");
            Console.WriteLine("Тираж: " + Edition + "\n");
        }
    }
    






    public class Book : Print
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Seria { get; set; }
        public string Language { get; set; }
        public string Translator { get; set; }

        public void Read()
        {
            Console.Write("Читаю книгу " + PublicationName + "...");
            for (int i = 0; i < 15; i++)
            {
                Console.Write("...");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Well Done! Книга " + PublicationName + " прочитана!");
        }
        public void bookReview()
        {
            Console.Write("\n\nТеперь надо оставить отзыв. Пишите здесь: ");
            string review = Console.ReadLine();
            Console.WriteLine("Готово! Спасибо за отзыв - вот так он выглядит:\n");
            Console.WriteLine("========================================\n");
            Console.WriteLine(review);
            Console.WriteLine("========================================\n");
        }

        public override void ShowPrint()
        {
            Console.WriteLine("Книга: " + PublicationName + "\n");
            Console.WriteLine("Жанр: " + Genre + "\n");
            Console.WriteLine("Серия: " + Seria + "\n");
            Console.WriteLine("Автор: " + Author + "\n");
            Console.WriteLine("Год: " + PublishingYear + "\n");
            Console.WriteLine("Язык Оригинала: " + Language + "\n");
            Console.WriteLine("Переводчик: " + Translator + "\n");
            Console.WriteLine("Издательство: " + PublishingHouseName + "\n");
            Console.WriteLine("Тираж: " + Edition + "\n");
        }
    }

    public class ClassBook : Print
    {
        private int classook_grade;

        public string Subject { get; set; }
        public string Author { get; set; }
        public int Grade
        {
            get
            {
                return classook_grade;
            }
            set
            {
                if (value < 1) classook_grade = 1;
                else if (value > 11) classook_grade = 11;
                else classook_grade = value;
            }
        }

        public void Learn()
        {
            Console.Write("Начинаю изучение...");
            for (int i = 0; i < 15; i++)
            {
                Console.Write("#");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Well Done! Учебник " + PublicationName + " изучен!");
        }

        public override void ShowPrint()
        {
            Console.WriteLine("Учебник: " + PublicationName + "\n");
            Console.WriteLine("Предмет: " + Subject + "\n");
            Console.WriteLine("Класс: " + Grade + "\n");
            Console.WriteLine("Год: " + PublishingYear + "\n");
            Console.WriteLine("Издательство: " + PublishingHouseName + "\n");
            Console.WriteLine("Тираж: " + Edition + "\n");
        }


    }
}
