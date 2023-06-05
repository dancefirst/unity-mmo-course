using System;
namespace TextRPG2
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class Player : Creature
    {
        // 나중에 상속받으니까 protected
        // 변수에 기본 디폴트값 넣어주기.
        protected PlayerType type = PlayerType.None;

        // 플레이어를 생성할 때는 무조건 타입을 받도록 하고 싶다 .
        // 인자를 받는 버전을 정의한 순간부터 인자 없는 버전은 사용불가 .
        // Knight, Mage 등으로 간접적으로 플레이어 생성하도록 하기 위해
        // protected Player 적용한다 .
        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }

        public PlayerType GetPlayerType() { return type; }

    }

    class Knight : Player
    {
        // 생성자 = 클래스랑 이름이 똑같고 반환 형식은 없는 친구
        // 생성자에서 자기 부모 클래스의 생성자를 호출하는 방식 - base(params)
        // public으로 해야 외부에서 생성할 수 있다 .
        public Knight() : base(PlayerType.Knight)
        {
            //type = PlayerType.Knight;
            SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            //type = PlayerType.Archer;
            SetInfo(75, 12);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            //type = PlayerType.Mage;
            SetInfo(50, 15);
        }
    }
}
