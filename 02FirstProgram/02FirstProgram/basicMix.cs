using System;

namespace _CsharpBasicbyHEHE
{
    class DefinitionAndMethod //命名方式 numberAsFastAsICan or Numberasfastasican
    {
        //name style

        #region 
        //region can fold redundance code

        int A = 5;//or
        int B; //声明变量就是确定变量类型
        double C = 2.0;
        float D = 4;
        char E = 'Z';
        double F = 2.3;
        int G;
        double H;
        int I;
        int J;
        double K;

        ///类、方法
        //comments  control+k+c uncomment control+k+u

        public void GivenValue()
        {
            B = 2;//赋值 变量B已在前面被声明
            K = A;//转换数据类型：显示
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
        {   //转换数据类型：隐式
            G = (int)F;
            return G;
        }

        public double DoubleORInt()
        {   //更隐晦的方式?表达转换数据类型：显式
            double DoubleorInt = A / B;//将会出现一个整数
            return DoubleorInt;
        }

        public double DoubleORInt1()
        {   //更隐晦的方式?表达转换数据类型：隐式
            double DoubleorInt1 = A / C;//将会出现一个小数
            return DoubleorInt1;
        }

        public void Display()
        {   //print
            Console.WriteLine("first assginment about print" + E);
            Console.WriteLine("multiple and divide: {0}", Calculate());
            Console.WriteLine("multiple try to add a char with a double num: {0}", Calculate() + E);//char可以被计算
            Console.WriteLine("multiple quotian and remain: {0}, switch the type of an int num into double{1}", Calculate1(), SwitchType());//{0}, {1}是占位符
            Console.WriteLine(F.ToString());//转换数据类型
            Console.WriteLine(A);
            Console.WriteLine("数据类型转换\"显式\"{0},\n 数据类型转换\"隐式\"{1}", DoubleORInt(), DoubleORInt1());//\n是转义符：换行, \"是在文字中添加引号
        }
    }
    class basicMix
    {
        static void Main(string[] args)
        {
            DefinitionAndMethod newNum = new DefinitionAndMethod();
            newNum.GivenValue();
            newNum.Display();

            //plus and diminish
            //difference with ++i and i++, also ++ with --
            int i = 1;
            int k = i++;
            Console.WriteLine(k);
            int x = 1;
            int t = ++x;
            Console.WriteLine(t);
            Console.ReadKey();//console.readkey()不是同一效果
            //且realine和readkey之后需要等待用户操作，不会继续执行

            //readline()
            Console.WriteLine("ei wasup");
            string greetings = Console.ReadLine();
            if (greetings == "me good")//if elseif else
            {
                Console.WriteLine("great!");
                Console.ReadKey();
            }
            else if(greetings == "busy")
            {
                Console.WriteLine("ei, no worries, k?");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sorry, I don't get it.");
                Console.ReadKey();
            }
        }
    }
}
//waiting list: pointer, 