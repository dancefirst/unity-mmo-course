using System;
using System.Collections;
using System.Collections.Generic;

namespace OtherUsefulThings5
{
    class Program5
    {

        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }


        static void Main5(string[] args)
        {
            InputManager inputManager = new InputManager();

            // 구독신청 (그래야 알림을 받는다)
            // -= 하면 구독취소
            inputManager.InputKey += OnInputTest;

            while (true)
            {
                // A키를 누르면 알림이 간다 (구독신청 해놨으니깐)
                inputManager.Update();
            }
        }
    }
}
