using System;

namespace ObjectedOriented7
{

    // OOP - 다형성 ! polymorphism
    // 여러가지 형태로 가질 수 있다
    // "virtual" - "override"
    // **오버로딩 = 함수이름의 재사용(인자받는버전, 안받는버전)
    // **오버라이딩 = 다형성 !

    // 다형성을 언제 적용해야 할까 ?
    // 여러 클래스 누구나 공통적으로 사용하지만 내용은 타입별로 좀 다를 때 
    // 상위 계층에서 virtual 선언된 것을 하위계층에서 override~~
    // 타입별 구분이 필요 없으면 그냥 최상위 클래스에 한번만 정의해주면 된다!

    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }

    class Knight : Player
    {
        //public override void Move()
        //{
        //    base.Move(); // 부모 클래스의 함수를 먼저 호출 
        //    Console.WriteLine("Knight 이동!");
        //}

        // 만약에 오버라이딩을 하위계층에서 허용하지 않고자 한다면 ?
        public sealed override void Move()
        {
            base.Move();
            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {
        // Knight 클래스 계층에서 sealed 가 걸렸으므로 오버라이딩 불가능.
        //public override void Move()
        //{
        //    base.Move(); // 부모 클래스의 함수를 먼저 호출 
        //    Console.WriteLine("SuperKnight 이동!");
        //}

        // 대신 new를 이용하여 함수 오버로딩은 가능하다 (덮어씌우기)
        public new void Move()
        {
            Console.WriteLine("슈퍼나이트의 반란!!");
        }
    }

    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            
            Console.WriteLine("Mage 이동!");
        }
    }

    class Program7
    {
        static void EnterGame(Player player)
        {

            player.Move();
            
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
                mage.Move();
            }

        }

        static void Main7(string[] args)
        {
            Knight knight = new Knight();
            SuperKnight knight2 = new SuperKnight();
            Mage mage = new Mage();

            knight.Move(); // Player 이동, Knight 이동 
            knight2.Move(); // 슈퍼나이트의 반란
            mage.Move(); // Mage 이동
            EnterGame(mage); // Mage(=player) 이동, Mage 이동
        }
    }
}
