using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    public class Session
    {
        public static List<Session> list = new List<Session> { };
        public int number;
        public int number_of_questions;
        public string offset { get; set; } = "Неопределённый зачёт";
        public string exam { get; set; } = "Неопределённый экзамен";
        public void Add(Session session)
        {
            list.Add(session);
        }
        public static void Remove(int position)
        {
            list.RemoveAt(position);
        }
        public static void Display()
        {
            foreach (Session i in list)
            {
                Console.WriteLine($"Объект {i.number}: ");
                Console.WriteLine(i.offset);
                Console.WriteLine(i.exam);
            }
        }

        public static class Control
        {
            public static void Find(string exam)
            {
                foreach (Session i in Session.list)
                {
                    if (Convert.ToString(i.exam).CompareTo(exam)==1)
                    {                        
                        Console.WriteLine($"Искомый экзамен находится в объекте под номером {i.number}");                        
                    }
                }                    
            }
            public static void Count()
            {
                int counter = 0;
                foreach (Session i in Session.list)
                {
                    counter++;
                }
                Console.WriteLine($"Испытаний в сессии: {counter}");
            }
            public static void Count2(int param)
            {
                int counter = 0;
                foreach (Session i in Session.list)
                {
                    if (i.number_of_questions==param)
                    {
                        Console.WriteLine($"Испытание с искомым количеством вопросов находится в элементе с индексом {counter}");
                        counter++;
                    }
                }
            }
        }
    }
}
