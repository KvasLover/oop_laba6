using System;
using System.Collections.Generic;

namespace laba6
{
    enum Seasons
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    struct House
    {
        private string street;
        public int floors;
        public int rooms;
        public void DisplayInfo()
        {
            Console.WriteLine($"Улица: {street}\nЭтажей: {floors}\nКомнат: {rooms}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {               
            try
            {
                // Для генерации исключения передать нуль.
                Exam exam = new Exam { Get_Setter = 0 };
            }
            catch (Number_is_equal_0 ex)
            {
                Console.WriteLine("Number_is_equal_0");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n");
            }
            finally
            {
                Console.WriteLine("Это конец первого обработчика исключений.");
            }

            try
            {
                Exam exam = new Exam { Get_Setter2 = "Exam" };
            }
            catch (Var_is_not_equal_exam ex)
            {
                Console.WriteLine("Var_is_not_equal_exam");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n");
            }

            try
            {
                Exam exam = new Exam { Get_Setter3 = "Br" };
            }
            catch (Length_of_Var_is_less_than_4 ex)
            {
                Console.WriteLine("Length_of_Var_is_less_than_4");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n");
            }

            // Стандартные исключения.
            try
            {
                Console.WriteLine("На какое число желаете поделить?");
                Exam exam = new Exam { Get_Setter4 = Convert.ToInt32(Console.ReadLine()) };
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n");
            }

            try
            {
                Console.WriteLine(" Вам дан массив из пяти элементов. Элемент с каким индексом вывести?");
                Exam exam = new Exam { Get_Setter5 = Convert.ToInt32(Console.ReadLine()) };
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException");
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}\n");
            }

 /*           // Стандартное переопределение.
            Exam exam2 = new Exam();
            exam2.Show_date();

            // Переопределение с использованием Upcast.
            Test test = new Test();            
            Quest quest = test;
            quest.Show_date();

            // Upcast при инициализации.
            Quest final_exam = new Final_Exam();
            final_exam.Show_date();

            // Ошибка, невозможно создать экземпляр
            // абстрактного класса:
            // Question question = new Question();
            // (но можно создать класс-наследник).

            // Переопределённый метод ToString().
            Console.WriteLine(final_exam.ToString());

            // Не переопределённый метод ToString().
            Console.WriteLine(quest.ToString());

            // 4).
            UserClass userclass = new UserClass();
            userclass.DoAnswer();
            ((IAnswer)userclass).DoAnswer();

            // Использование операторов is и as.
            Console.WriteLine(quest is Quest);
            Quest quest2 = quest as Quest;
            quest2.Show_date();

            // 6).
            Console.WriteLine(exam2.ToString());
            Console.WriteLine(quest.ToString());
            Console.WriteLine(test.ToString());
            Console.WriteLine(final_exam.ToString());

            // 7).
            IRealizable[] Array = { quest, test, exam2 };
            Printer printer = new Printer();
            for (int i = 0; i < Array.Length; i++)
            {
                printer.iAmPrinting(Array[i]);
            }

            // 3).
            List<Session> list = new List<Session> { };
            Session session1 = new Session();
            session1.offset = "Химия";
            session1.exam = "ООП";
            Session session2 = new Session();
            session2.offset = "Философия";
            session2.exam = "Математика";
            Session session3 = new Session();
            session3.offset = "Психология";
            session3.exam = "Дизайн";

            // Добавление элементов в список.
            session1.number = 1;
            session2.number = 2;
            session3.number = 3;
            session1.number_of_questions = 4;
            session2.number_of_questions = 5;
            session3.number_of_questions = 6;
            session1.Add(session1);            
            session2.Add(session2);
            session3.Add(session3);            

            // Вывод списка.
            Session.Display();

            // Удаление элемента из списка
            Session.Remove(1);

            // Вывод списка.
            Session.Display();

            // 4).
            Session.Control.Find("Дизайн");
            Session.Control.Count();
            Session.Control.Count2(4);
*/
        }
    }
}
