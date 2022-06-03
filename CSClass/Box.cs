using System;

namespace CSClass
{
    public class Box
    {
        //prop + tab + tab -> 빠른 속성 생성

        private int width;
        public int Width {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("양수를 입력해주세요!!");
                }
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("양수를 입력해주세요!!");
                }
            }
        }

        public int Area
        {
            get { return this.width * this.height; }
        }

        public Box(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        
    }
}