using System;

namespace ObjectedOriented2
{
    
    class Knight
    {
        // 클래스 내부에 선언된 변수들 -> "필드"라고도 함
        public int hp;
        public int attack;

        // 생성자
        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }


        // 인자를 받는 버전의 생성자!
        // 상속?을 이용한 생성자의 연속 호출 --- : this()
        public Knight(int hp) : this() // public Knight()를 먼저 호출하고 실행된다.
        {
            this.hp = hp;
            // _hp = hp; - 이런 식으로 처리하기도 한다.
            Console.WriteLine("int 생성자 호출!");
        }

        public Knight(int hp, int attack) : this() // public Knight()를 먼저 호출하고 실행된다.
        {
            this.hp = hp;
            this.attack = attack;
            // _hp = hp; - 이런 식으로 처리하기도 한다.
            Console.WriteLine("int attack 생성자 호출!");
        }


        public Knight Clone()
        {
            Knight knight2 = new Knight();
            knight2.hp = hp;
            knight2.attack = attack;
            return knight2;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }
    
    class Program2
    {
        static void Main2(string[] args)
        {
            Knight knight = new Knight(); // 기본 생성자 
            Knight knight2 = new Knight(33); // 기본생성자 -> int 생성자
            Knight knight3 = new Knight(33, 500); // 기본생성자 -> int,attack 생성자 
        }
    }
}
