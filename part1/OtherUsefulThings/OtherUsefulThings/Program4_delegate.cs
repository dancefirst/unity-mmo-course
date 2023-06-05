using System;
using System.Collections.Generic;

namespace OtherUsefulThings4
{
    class Program4
    {
        // 업체 사장 - 사장님의 비서
        // 사장님 부재중 -> 연락처 용건을 말하고 나한테 연락 좀 해달라고 요청

        delegate int OnClicked();
        // delegate -> 형식은 형식인데 함수 자체를 인자로 넘겨주는 그런 형식
        // 반환 int / 입력 void
        // OnClicked -> delegate 형식의 이름 !

        // UI 작업할 때 예시--
        // UI 로직과 게임 동작 로직은 분리시키는 게 바람직하다
        static void ButtonPressed(OnClicked clickedFunction/*함수 자체를 인자로 넘겨주고*/)
        {
            // 넘겨받은 인자 함수를 호출하면 편하겠다 !
            // 이 방식을 CallBack 방식이라고 한다.
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Hello Delegate 2");
            return 0;
        }

        static void Main4(string[] args)
        {
            // delegate (대리자)
            //ButtonPressed(TestDelegate);

            // delegate 객체를 만들었을 때의 장점 ??
            // delegate를 체인으로 이어줄 수 있다 !
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;

            ButtonPressed(clicked);
        }
    }
}
