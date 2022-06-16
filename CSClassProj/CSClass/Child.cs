using System;

namespace CSClass
{
    public class Child : Parent
    {
        public Child() : base()
        {
            Console.WriteLine("자식 생성자");
        }

        public Child(int input) : base(input)
        {
            Console.WriteLine("Child(int input) : base(input)");
        }

        public Child(String input) : base(input)
        {
            Console.WriteLine("Child(String input) : base(input)");
        }


        public void CountChild()
        {
            Child.counter++;    //부모클래스에 있는 counter를 1씩 증가시킴
        }
    }
}