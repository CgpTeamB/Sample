﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原始的スタック
{
    class Program
    {
        
        static int[]stack=new int[10];
        static int a = 0;
<<<<<<< HEAD
        static int b = 180;
<<<<<<< HEAD
        int g = 8000;
=======
=======
        static int b;

>>>>>>> refs/remotes/origin/new-one
>>>>>>> origin/master
        static void push(int b) 
        {   
            stack[a]=b;
            a++;
        }

        static int Pop()
        {
            a--;
            return stack[a];
        }


        static void Main(string[] args)
        {
            push(1);
            push(2);
            Console.WriteLine(Pop());
            push(3);
            Console.WriteLine(Pop());

            Console.WriteLine("Finish");
        }
    }
}
