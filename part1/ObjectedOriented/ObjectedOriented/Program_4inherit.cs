using System;

namespace ObjectedOriented4
{

    // OOP - 상속성
    // 다양한 직업이 존재한다면 ??
    // 중복되는 데이터나 코드를 공통으로 쓰게 할 수 없을까 ?

    class Player // 부모 클래스 또는 기반 클래스 
    {
        static public int counter; // 클래스 객체 모두에 공통, 오로지 하나만 존재.

        // 인스턴스 독립적인 필드 변수들
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("Player hp 생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Player Move");
        }

        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }
    }

    class Mage : Player // 자식 또는 파생 클래스
    {

    }

    class Archer : Player // 자식 또는 파생 클래스
    {

    }

    
    class Knight : Player // 자식 또는 파생 클래스
    {

        int c;

        // public Knight() : Player(100) 동일한 의미의 코드!
        public Knight() : base(100)
        {
            this.c = 10; // 내 클래스 필드에 접근
            base.hp = 100; // 부모 클래스 필드에 접근

            Console.WriteLine("Knight 생성자 호출!");
        }


        // 물론 함수 내에서 직접 인스턴스를 만든다면 static으로도 개별 인스턴스에 접근 가능.
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            return knight;
        }


        public Knight Clone()
        {
            Knight knight2 = new Knight();
            knight2.hp = hp;
            knight2.attack = attack;
            return knight2;
        }

        public void Stun()
        {
            Console.WriteLine("Knight Stun!");
        }


    }
    
    class Program4
    {
        static void Main4(string[] args)
        {

            Knight knight = new Knight();
            knight.Move();
            knight.Attack();
            knight.Stun();

        }
    }
}
