using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("고양이가 사료를 먹습니다.");
        }

        public void Meow()
        {
            Console.WriteLine("야옹 웁니다.");
        }
    }
}