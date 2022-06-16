using System;

namespace CSClass
{
    public class Animal
    {
        public int Age { get; set; }

        public Animal()
        {
            Age = 0;
        }

        public virtual void Eat()
        {
            Console.WriteLine("잘 먹겠습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("잠을 잡니다.");
        }
    }
}