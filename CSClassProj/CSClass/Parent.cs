﻿using System;

namespace CSClass
{
    public class Parent
    {
        public static int counter = 0;
        public int variable = 273;

        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }

        //오버라이딩을 허용하겠다
        public virtual void Method2()
        {
            Console.WriteLine("부모의 메서드2");
        }

        public void CountParent()
        {
            Parent.counter++;
        }

        public Parent()
        {
            Console.WriteLine("부모 생성자");
        }

        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }

        public Parent(String param)
        {
            Console.WriteLine("Parent(String param)");
        }
    }
}