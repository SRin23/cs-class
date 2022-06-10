using System;

namespace CSClass
{
    public class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog()
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

        public void Bark()
        {
            Console.WriteLine("월월 짖습니다.");
        }
    }
}