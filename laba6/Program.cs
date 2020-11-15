using System;

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
            // Стандартное переопределение.
            Exam exam = new Exam();
            exam.Show_date();

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

            // Использование операторов is и as.
            Console.WriteLine(quest is Quest);
            Quest quest2 = quest as Quest;
            quest2.Show_date();

            // 6).
            Console.WriteLine(exam.ToString());
            Console.WriteLine(quest.ToString());
            Console.WriteLine(test.ToString());
            Console.WriteLine(final_exam.ToString());

            // 7).
            IRealizable[] Array = { quest, test, exam };
            Printer printer = new Printer();
            for (int i = 0; i < Array.Length; i++)
            {
                printer.iAmPrinting(Array[i]);
            }
        }
    }
}
