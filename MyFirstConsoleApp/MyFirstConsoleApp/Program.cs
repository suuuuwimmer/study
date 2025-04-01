using System;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(String[] args)
        {
            OperatorExamples();
            //출력
        }

        private static void OperatorExamples()
        {
            // 이 명령문은 변수를 선언하고 3을 할당합니다.
            int width = 3;

            // ++ 연산자는 변수의 값을 1만큼 증가시킵니다.
            width++;

            //숫자를 할당할 수 있는 변수 2개를 선언하고
            // +, * 연산자를 사용해 수를 더하고 곱해 봅시다.
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            // 다음 두 명령문은 string 변수 2개를 선언하고
            // + 연산자를 사용해 두 문자열을 연결합니다.
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            // 불리언 타입의 변수는 true 혹은 false 값을 가집니다.
            bool truthValue = true;
            Console.WriteLine(truthValue);
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn't 10");
            }
        }

        private static void TrySomeLoops()
        {
            int counts = 0;
            while (counts < 10) { counts = counts + 1; }
            for (int i = 0; i < 5; i++) { counts = counts - 1; }
            Console.WriteLine("The answer is"+counts);
        }
    }
}

