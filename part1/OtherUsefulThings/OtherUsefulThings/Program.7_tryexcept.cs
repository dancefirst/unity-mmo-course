using System;
using System.Collections;
using System.Collections.Generic;

namespace OtherUsefulThings7
{



    class Program7
    {

        class TestException : Exception
        {

        }

        static void Main7(string[] args)
        {
            // try-catch는 게임에서는 그다지 ? 로직을 빨리 수정하는 게 낫다.
            // 네트워크 변수 등에서는 사용할 수도 있으니까 ~

            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를 참조하는 경우 (null, 캐스팅 실수)
                // 3. 오버플로우 (메모리 초과)

                //int a = 10;
                //int b = 0;
                //int result = a / b;

                throw new TestException();

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zero Error!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
            }
            finally // 무조건 실행시키고 싶은 ~
            {
                Console.WriteLine("Finally!");
                // DB, 파일 정리 등등 
            }
        }
    }
}
