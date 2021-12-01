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
        double PriceOfCoffee;
        double PriceOfTea;
        public const int L = 5;//常量
        #endregion

        ///类、方法
        //comments  control+k+c uncomment control+k+u

        public void GivenValue()
        {
            B = 2;//赋值 变量B已在前面被声明
            K = A;//转换数据类型：显示
            PriceOfCoffee = 32;
            PriceOfTea = 25;
        }

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
            Console.WriteLine("first assginment a\babout print" + E);//\b是一个backspace删除前一个字符，且句子的头尾不起作用sys不支持
            Console.WriteLine("multiple and divide: \t{0}", Calculate());//\t是一个tab
            Console.WriteLine("multiple try to add a char with a double num: {0}", Calculate() + E);//char可以被计算
            Console.WriteLine("multiple quotian and remain: {0}, switch the type of an int num into double{1}", Calculate1(), SwitchType());//{0}, {1}是占位符
            Console.WriteLine(F.ToString());//转换数据类型
            Console.WriteLine(A);
            Console.WriteLine("数据类型转换\"显式\"{0}, \n数据类型转换\"隐式\"{1}", DoubleORInt(), DoubleORInt1());//\n是转义符：换行, \"是在文字中添加引号
            Console.WriteLine(@"\A\B\C");//@保证程序输出地址栏，即取消\的转义符作用
            Console.WriteLine(@"黑，
            你好");//用@将字符串按原格式输出
        }

        public void PPIandIPP()
        {
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
        }

        public void Chat()
        {
            //readline()
            Console.WriteLine("ei wasup");
            string greetings = Console.ReadLine();
            if (greetings == "me good")//if elseif else
            {
                Console.WriteLine("great!");
                Console.ReadKey();
            }
            else if (greetings == "busy")
            {
                Console.WriteLine("ei, no worries, k?");
                Console.ReadKey();
                Console.WriteLine("hum, let's say someone will have good lcuk today");
                Console.ReadKey();
                Console.WriteLine("You wanna a cup of coffee?");
                string TeaOrCoffee = Console.ReadLine();
                if (TeaOrCoffee == "coffee")
                { 
                    Console.WriteLine("how many?");
                    int much = Convert.ToInt32(Console.ReadLine());
                    double total = much * PriceOfCoffee;
                    Console.WriteLine("There you go. I paid {0} for you. a..a.aha.. Nothing.", total);
                }
            }
            else
            {
                Console.WriteLine("Sorry, I don't get it.");
                Console.ReadKey();
            }
        }
    }
    class basicMix
    {
        static void Main(string[] args)
        {
            DefinitionAndMethod newNum = new DefinitionAndMethod();
            newNum.GivenValue();
            newNum.PPIandIPP();
            newNum.Display();
            newNum.Chat();
        }
    }
}
//waiting list: pointer, && ||, 