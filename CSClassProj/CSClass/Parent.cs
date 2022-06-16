using System;

namespace CSClass
{
    //public sealed class Parent
    //public abstract class Parent
    public class Parent
    {
        public static int counter = 0;
        public int variable = 273;

        //abstract public void Method3(); //무조건 구현해야한다(싱속받는곳에서) - 추상 메서드

        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }

        //오버라이딩을 허용하겠다
        //sealed사용시, 클래스에서 오버라이딩을(상속) 막아버려서 에러가 난다.
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