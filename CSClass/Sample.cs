using System;

namespace CSClass
{
    class Sample
    {
        public static int value = 42;
        
        //정적변수에는 매개변수 X
        static Sample()
        {
            value = 99;
            Console.WriteLine("Sample() 정적 생성자 호출");
        }

        public Sample()
        {
            Console.WriteLine("Sample() 일반 생성자 호출");
        }
    }
}