using System;

namespace Person
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Human("Ivan", 25);
            
            human.ShowInfo();
        }
    }
}