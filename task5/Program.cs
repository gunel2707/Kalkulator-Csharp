using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //*********************************************************
            //Console.WriteLine("Duzbucaqlinin enini daxil edin");
            //int var1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Duzbucaqlinin uzunlugunu daxil edin");
            //int var2 = int.Parse(Console.ReadLine());
            //var result = var1* var2;
            //var result1=2*(var1+var2);
            //Console.WriteLine("Duzbucaqlinin sahesi:" + result.ToString());
            //Console.WriteLine("Duzbucaqlinin perimetri:" + result.ToString());
            //Console.ReadKey();
            //////////////////////////////////////////////////////////////////////////////////////      

            //task2
            //İstifadəçidən 2 int dəyər alın və birinci ədədi ikinciyə bölün . Misal: 16, 5. Nəticə 3 yox, 3,2 olmalıdır.
            //Console.WriteLine("Birinci ededi daxil edin:");
            //int var1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ikinci ededi daxil edin:");
            //int var2 = int.Parse(Console.ReadLine());
            //double result =(double) var1 / var2;
            // Console.WriteLine("result:" + result.ToString());
            //Console.ReadKey();
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //task3
            //Tip Çevirmelerine aid 5 nümunə yazın
            // int i = 10;
            // Console.WriteLine(i);
            //double result =(double)i;
            // Console.WriteLine("result:"+result.ToString());
            //********************************************************
            //short val5 = 275;
            //byte val6 = (byte)val5;

            //Console.WriteLine(val6);
            //*******************************************************
            //var value = Convert.ToInt16(false);
            //Console.WriteLine(value);
            //****************************************
            //var value = Convert.ToInt32(true);
            //Console.WriteLine(value);
            //********************************
            //var value = Convert.ToDouble(456);
            //Console.WriteLine(value);
            //****************************************
            //int i = 10;
            //var j = i + 1;
            //Console.WriteLine(j.ToString() + j.GetType());
            //*******************************************
            short i = 10;
            byte t = 1;
            var j = i + t;
            Console.WriteLine(j.ToString()+ j.GetType());
            Console.ReadLine();
            //*******************************************************
            //var value = double.TryParse(Console.ReadLine(), out double result);

            //if (value) Console.WriteLine(result);
            //else Console.WriteLine("Data type is incorrect");



            ///////////////////////////////////////////////////////////////////////////////

            //task4
            //Ədədlər üzərində operatorlardan istifadə etməklə nümunələr yazın.
            //  Hər operotara aid 1 nümunə.Fərqli data typle - lardan istifadə edin

            //  Console.WriteLine("Birinci ededi daxil edin:");
            //double var1 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Ikinci ededi daxil edin:");
            //   int var2 = int.Parse(Console.ReadLine());
            //  double result = (float)var1 / var2;
            //  Console.WriteLine("result:" + result.ToString());


            //     Console.WriteLine("Birinci ededi daxil edin:");
            //   float var1 = float.Parse(Console.ReadLine());
            //     Console.WriteLine("ikinci ededi daxil edin:");
            //float var2 = float.Parse(Console.ReadLine());
            //    float result = (float)var1 * var2;
            //     Console.WriteLine("result:" + result.ToString());



            //Console.WriteLine("Birinci ededi daxil edin:");
            //byte var1 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("ikinci ededi daxil edin:");
            //float var2 = float.Parse(Console.ReadLine());
            //float result = (float)var1 + var2;
            //Console.WriteLine("result:" + result.ToString());


            //   Console.WriteLine("Birinci ededi daxil edin:");
            //   byte var1 = byte.Parse(Console.ReadLine());
            //   Console.WriteLine("ikinci ededi daxil edin:");
            //   float var2 = float.Parse(Console.ReadLine());
            //float result = (float)var1 -var2;
            //   Console.WriteLine("result:" + result.ToString());



            //Task5
            //int number1 = 7;
            //            int number2 = 8;
            //            int number3 = 9;
            //            var result = !(number1 <= number2) == (number3 != number3++);
            //            Console.WriteLine("result:" + result.ToString());

            //            Console.WriteLine((number3 != ++number3).ToString());
            //            Console.WriteLine((number1 <= number2).ToString());



        }
    }
}
