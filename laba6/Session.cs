using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    public class Session
    {
        static List<Session> list = new List<Session> { };
        public int number;
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
    }
}
