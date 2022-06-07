using System;

namespace CSClass
{
    public class Method
    {
        int instanceVariable = 10;
        static int classVariable = 10;
        public double Multi(double v1, int v2)
        {
            return v1 * v2;
        }

        /// <summary>
        /// min부터 max까지의 합
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">도달값</param>
        /// <returns>min부터 max까지의 합계</returns>
        public int Sum(int min, int max)
        {
            int output = 0;
            for(int i = min; i <= max; i++)
            {
                output += i;
            }
            return output;
        }

        /// <summary>
        /// min부터 max까지의 곱
        /// </summary>
        /// <param name="min">시작값</param>
        /// <param name="max">도달값</param>
        /// <returns>min부터 max까지의 곱</returns>
        public int Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i <= max; i++)
            {
                output *= i;
                //Console.WriteLine(i + " : " + output);
            }
            return output;
        }

        //클래스 메서드는 객체 생선 전에도 호출할 수 있다
        static public void some()
        {
            //this.Multiplay(1, 10);  //클래스 메서드 내에서 해당 객체의 인스턴스에 접근할 수 없다.
            //Console.WriteLine(instanceVariable); 
            Console.WriteLine(classVariable);
        }

        public static int Abs(int input)
        {
            if(input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }
}