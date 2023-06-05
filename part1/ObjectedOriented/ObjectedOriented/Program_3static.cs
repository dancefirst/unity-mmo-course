using System;

namespace ObjectedOriented3
{
    
    class Knight
    {
        // 클래스 내부에 선언된 변수들 -> "필드"라고도 함
        // static??

        static public int counter; // 클래스 객체 모두에 공통, 오로지 하나만 존재.

        // 인스턴스 독립적인 필드 변수들
        public int id;
        public int hp;
        public int attack;

        // static을 붙인다는 것의 의미 -> 개별 붕어빵이 아니라 붕어빵 틀에 종속적!
        static public void Test()
        {
            counter++;
        }

        // 물론 함수 내에서 직접 인스턴스를 만든다면 static으로도 개별 인스턴스에 접근 가능.
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            return knight;
        }


        // 생성자
        public Knight()
        {
            // 생성자 호출 시마다 static 변수인 카운터를 증가시킨다.
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
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
    
    class Program3
    {
        static void Main3(string[] args)
        {
            Knight knight = new Knight();
            Knight knight2 = new Knight();
            Knight knight3 = new Knight();

            // 클래스 자체에 종속적인 함수이므로 직접호출이 가능하다.
            Knight knight4 = Knight.CreateKnight(); // static
            knight4.Move(); // non-static

            // ---static 예시
            // Console.WriteLine();

            // ---non-static 예시
            // Random rand = new Random();
            // rand.Next(0, 2);

        }
    }
}
