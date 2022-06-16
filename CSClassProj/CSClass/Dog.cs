using System;

namespace CSClass
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public override void Eat()
        {
            Console.WriteLine("강아지가 사료를 먹습니다.");
        }

        public void Bark()
        {
            //this.Eat(); //현재 객체의 Eat 호출
            //base.Eat(); //부모 클래스의 Eat 호출
            Console.WriteLine("월월 짖습니다.");
        }
    }
}