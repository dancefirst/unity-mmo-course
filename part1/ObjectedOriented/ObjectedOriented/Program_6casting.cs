using System;

namespace ObjectedOriented6
{

    // OOP - 클래스의 형변환 

    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class Program6
    {

        // null의 사용례 - 메소드 반환 
        static Player FindPlayerByID(int id)
        {
            // id 해당하는 플레이어 탐색

            // 못찾았으면 ?
            return null;
        }

        static void EnterGame(Player player)
        {
            // 메소드 매개변수가 Knight 타입으로 들어올 경우 실행과정에서 크래쉬
            // 그래서 클래스의 종류를 먼저 질문해볼 수 있다 !

            // 1번 접근 - bool
            //bool isMage = (player is Mage);
            //if (isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}

            // 2번 접근 - as 이용
            // (player as Mage) 코드 실패 시 -> null 반환되어 저장된다.
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }
        }

        static void Main6(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            // Mage 타입이라면 Player 타입으로 형변환 가능하다 - 항상 가능하다.
            // 하지만 Player 타입이라면 Mage 타입으로 형변환 불가능할 수 있다 (크로스체크 필요)
            // 확실하게 해 주려면 (Mage) casting 해준다, 하지만 충돌 존재하면 실행되지 않는다.
            Player magePlayer = mage;
            Mage mage2 = (Mage)magePlayer;

            // EnterGame 매개변수를 player로 정의했을때
            // player의 자식 클래스인 knight, mage 또한 매개변수로 받을 수 있다!
            EnterGame(knight);
            EnterGame(mage);
        }
    }
}
