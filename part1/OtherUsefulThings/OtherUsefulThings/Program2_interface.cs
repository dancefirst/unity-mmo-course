using System;
using System.Collections.Generic;

namespace OtherUsefulThings2
{
    class Program2
    {

        // 추상 클래스 ? -> 클래스를 설계할 때 행동에 제약을 가하는 것.
        // 추상 클래스는 인스턴스를 직접 생성할 수 없다 .
        abstract class Monster
        {
            //public virtual void Shout() { }
            public abstract void Shout(); // 정의가 불가능하고 개념으로만 존재.

            // 추상 클래스를 상속받는 모든 클래스는 ,
            // 추상 클래스에 선언된 추상 메소드를 반드시 오버라이딩 해야 한다.
        }

        // 다중 클래스 상속의 문제를 해결하면서 ~ 다양한 상속을 가능하게 하는!
        // 인터페이스를 상속 받는다면 내용은 상관없고 특정 메소드를 물려받아야 한다 !
        interface IFlyable
        {
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }
        }

        // 다중상속은 불가능하다 ! 그러나 인터페이스를 물려받을 수 있다 .
        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("플라잉 록타르 오가르!");
            }
        }


        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("꾸에에!");
            }
        }


        static void DoFly(IFlyable flyable)
        {
            // IFlyable이면 무조건 Fly()가 가능하므로 ,
            flyable.Fly();
        }


        static void Main2(string[] args)
        {
            // 인터페이스 형태로도 저장할 수 있다 
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable); // "플라잉 록타르 오가르"

            // 본래 클래스 형으로도 물론 저장 가능하다
            FlyableOrc fOrc = new FlyableOrc();
            DoFly(fOrc); // "플라잉 록타르 오가르"

        }
    }
}
