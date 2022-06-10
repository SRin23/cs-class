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
            Console.WriteLine(random.NextDouble() * 10);

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

            //집합일 경우 변수를 복수형으로 작성하는 것이 좋다
            /* 
                       List<Student> students = new List<Student>();
                       students.Add(new Student() { name = "김세린", grade = 3 });
                       students.Add(new Student() { name = "김다흰", grade = 2 });
                       students.Add(new Student() { name = "김미나", grade = 3 });
                       students.Add(new Student() { name = "김민정", grade = 1 });
                       students.Add(new Student() { name = "김소연", grade = 1 });
                       students.Add(new Student() { name = "김지수", grade = 2 });
                       students.Add(new Student() { name = "김지호", grade = 3 });
                       students.Add(new Student() { name = "김찬희", grade = 1 });
                       students.Add(new Student() { name = "김하늘", grade = 2 });
                       students.Add(new Student() { name = "김효리", grade = 1 });
            */

            List<Student> students = new List<Student>()
            {
                new Student() { name = "김세린", grade = 3 }, 
                new Student() { name = "김다흰", grade = 2 }, 
                new Student() { name = "김미나", grade = 3 }, 
                new Student() { name = "김민정", grade = 1 }, 
                new Student() { name = "김소연", grade = 1 }, 
                new Student() { name = "김지수", grade = 3 }, 
                new Student() { name = "김지호", grade = 3 }, 
                new Student() { name = "김찬희", grade = 1 }, 
                new Student() { name = "김하늘", grade = 2 }, 
                new Student() { name = "김효리", grade = 1 },
            };

            //foreach는 삭제할때는 잘 사용하지 않는다.
            /*          foreach (var item in students)
                      {
                          if (item.grade > 2)
                          {
                              Console.WriteLine(item);
                              //students.Remove(item);    //삭제되며 객체가 앞으로 오게 되어 index에 문제가 생겨 error를 반환함
                          }
                          //Console.WriteLine(item);
                      }
            */

            //spanner : 속성을 일컫는다.
            //네모난 상자 : 필드를 일컫는다.
            /*            for (int i = 0; i < students.Count; i++)
                        {
                            if (students[i].grade > 2)
                            {
                                students.RemoveAt(i);   //김지호에서 grade가 연속적으로 나와 3이 출력되게 된다. (index에 의해) -> 이를 해결하기 위해 뒤에서부터 반복문 실행
                                //students.Remove(students[i]);
                                i--;
                            }
                        }
            */

            Console.WriteLine("==============================================");

            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                }
            }

            foreach(var item in students)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("==============================================");

            Method method = new Method();
            Console.WriteLine("곱하기 : " + method.Multi(52.1, 273));

            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 100)); //Overflow로 인해 0이 출력됨
            Console.WriteLine(Method.Abs(-100));
            Console.WriteLine(Method.Abs(100));

            //Method Overloading
            //int
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));

            //double
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-52.273));

            //long
            Console.WriteLine(MyMath.Abs(987654321123456));
            Console.WriteLine(MyMath.Abs(987654321123456));


            Console.WriteLine("==============================================");

            Product product1 = new Product("고구마", 3000);
            Product product2 = new Product("감자", 5000);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");

            //ver1
            /*
                        Console.WriteLine("첫번째 위치");
                        Console.WriteLine(Sample.value);
                        Console.WriteLine("두번째 위치");
                        Sample sample = new Sample();
                        Console.WriteLine("세번째 위치");
            */

            //ver2
            //일반 생성자보다 정적 생성자가 먼저 호출됨

            Console.WriteLine("첫번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번째 위치");


            Console.WriteLine("==============================================");

            Box1 box1 = new Box1(10, 10);
            box1.width = -10;
            
            Console.WriteLine("box1의 면적은 " + box1.Area() + "입니다.");

            Box2 box2 = new Box2(10, 10);
            box2.setWidth(-10);
            Console.WriteLine("box2의 면적은 " + box2.Area() + "입니다.");

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box의 면적은 " + box.Area + "입니다.");

            Console.WriteLine("==============================================");

            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(10));
            Console.WriteLine(Fibonacci.Get(100));
            Console.WriteLine(Fibonacci.Get(1000));

            // List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            // List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
                //item.Bark();  //부모클래스에서는 자식클래스의 메서드를 호출할 수 없다.
                //((Dog)item).Bark(); //형변환 -> Cat에서 문제가 생김
            }
        }
    }
}
