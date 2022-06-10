using System;

namespace CSClass
{
    public class Cat
    {
        public int Age { get; set; }

        public Cat()
        {
            Age = 0;
        }

        public void Eat()
        {
            Console.WriteLine("잘 먹겠습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("잠을 잡니다.");
        }
        public void Meow()
        {
            Console.WriteLine("야옹 웁니다.");
        }
    }
}