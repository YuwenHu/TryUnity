﻿using System;

namespace _CsharpBasicbyHEHE
{
    class DefinitionAndMethod //命名方式 numberAsFastAsICan or Numberasfastasican
    {
        //name style

        #region 
        //region can fold redundance code

        int A = 5;//or
        int B; //声明变量就是确定变量类型
        double C = 1.2;
        float D = 4;
        char E = 'Z';
        double F = 2.3;
        int G;
        double H;
        int I;
        int J;

        ///类、方法
        //comments  control+k+c uncomment control+k+u

        public void GivenValue()
        {
            B = 2; //赋值 变量B已在前面被声明
        }
        #endregion

        public double Calculate()
        {
            H = (B + A + C) / D;
            return H;
        }

        public double Calculate1()
        {
            I = A / B;//两整数相除结果舍弃余数
            J = A % B;//取余
            return I + J;
        }

        public double SwitchType()
        {   //转换数据类型
            G = (int)F;
            return G;
        }

        public void Display()
        {   //print
            Console.WriteLine("first assginment about print" + E);
            Console.WriteLine("multiple and divide: {0}", Calculate());
            Console.WriteLine("multiple try to add a char with a double num: {0}", Calculate() + E);//char可以被计算
            Console.WriteLine("multiple quotian and remain: {0}, switch the type of an int num into double{1}", Calculate1(), SwitchType());//{0}, {1}是占位符
            Console.WriteLine(F.ToString());//转换数据类型
        }
    }
    class basicMix
    {
        static void Main(string[] args)
        {
            //plus and diminish
            //difference with ++i and i++, also ++ with --
            int i = 1;
            int k = i++;
            Console.WriteLine(k);
            int x = 1;
            int t = ++x;
            Console.WriteLine(t);
            Console.ReadLine();//console.readkey()是同一效果


            DefinitionAndMethod newNum = new DefinitionAndMethod();
            newNum.GivenValue();
            newNum.Display();
        }
    }
}
//waiting list: pointer, 