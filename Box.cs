﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        private int width;
        private int height;

        public Box(int width, int height)
        {
            if (width > 0 && height > 0)  // 원래는 예외처리 해야 함
            {
                this.width = width;
                this.height = height;
            } else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요!");
            }
        }

        public int getWidth() { return width; }
        public void setWidth(int width)
        {
            if (width > 0) // 원래는 예외처리 해야 함
            { 
                this.width = width; 
            }   
            else 
            { 
                Console.WriteLine("너비는 자연수로 초기화해주세요!");
            }
        }
        public int getHeiht() { return height; }
        public void setHeight(int height)
        {
            if (height > 0) // 원래는 예외처리 해야 함 
            { 
                this.height = height; 
            }   
            else 
            { 
                Console.WriteLine("너비는 자연수로 초기화해주세요!"); 
            }
        }
        public int Area() { return width * height; }
    }
}
