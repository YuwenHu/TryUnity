﻿using System;

namespace _CsharpBasicbyHEHE
{
    class DefinitionAndMethod //命名方式 numberAsFastAsICan or Numberasfastasican
    {
        //name style

        #region 
        //region can fold redundance code

        int A = 1;//or
        int B; //声明变量就是确定变量类型
        double C = 1.2;
        float D = 2;

        ///类、方法
        //comments  control+k+c uncomment control+k+u

        public void GivenValue()
        {
            B = 2; //赋值 变量B已在前面被声明
        }
        #endregion

        public double Calculate()
        {
            return (B + A + C) * D;
        }

        public void Display()
        {   //print
            Console.WriteLine("first assginment.");
            Console.WriteLine("multiple: {0}", Calculate());
        }
    }
    class basicMix
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("first assginment.");
            Console.WriteLine("why live?");
            Console.WriteLine("funplus");
            Console.ReadKey();

            //plus and diminish
            //difference with ++i and i++, also ++ with --
            int i = 1;
            int k = i++;
            Console.WriteLine(k);
            int x = 1;
            int t = ++x;
            Console.WriteLine(t);
        }
    }
}