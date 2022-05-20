using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOUtTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);
            
            /*
            List<int> list = new List<int>();
            
            list.Add(11);
            list.Add(21);
            list.Add(31);
            list.Add(41);
            */

            List<int> list = new List<int>() { 11, 21, 31, 41 };
            list.Remove(11);
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\t item: " + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));    //53
            Console.WriteLine(Math.Floor(52.273));    //52
            Console.WriteLine(Math.Max(52, 273));    //273
            Console.WriteLine(Math.Min(52, 273));    //52
            Console.WriteLine(Math.Round(52.273));    //52
            Console.WriteLine(Math.PI);

            //C#에서는 파일명과 클래스명이 달라도 괜찮지만 지양한다.
            Hamburger yummy = new Hamburger();

            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;

            //인스턴스 변수를 생성과 동시에 초기화가 가능하다(C#의 고유 문법)
            Product productB = new Product() { name = "소금빵", price = 2000 };
            Product productC = new Product() { price = 15000, name = "당근케이크" };
            Product productD = new Product() { name = "보름달" };
            Product productE = new Product() { price = 30000 };

        }
    }
}
