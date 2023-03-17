using System;

namespace Person
{
    public class Human
    {
        private string _name;
        private int _age;

        public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя: " + _name + "\nВозраст: " + _age);
        }
    }
}