using System;
namespace OtherUsefulThings5
{
    // Observer Pattern
    // 구독자를 모집한 다음, 특정 이벤트가 발생했을 때 구독자들에게 정보를 뿌리는 패턴.
    class InputManager
    {
        // delegate - 다 좋은데, 외부에서 멋대로 호출할 수 있다는 점이 걸리면 ?
        public delegate void OnInputKey();

        // event - delegate를 한번 더 wrapping한 것 .
        // 구독신청은 가능하지만, 마음대로 호출하는 것은 금지시킨다.
        public event OnInputKey InputKey;


        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                // 모두에게 알려준다 .
                InputKey();
            }
        }
    }
}
