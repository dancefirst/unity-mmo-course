using System;

namespace ObjectedOriented1
{
    // 객체지향 (OOP)

    // 객체설계를 해보자!
    // Knight
    // attribute: hp, attack, pos
    // function: Move, Attack, Die

    // STACK vs. HEAP
    // Mage (struct) -> 스택에 직접 정보가 할당된다. (att, hp)
    // Knight (class) -> 스택에 메모리주소가 저장되고, 본체는 힙에 생성된다.
    //                -> 본체는 꼭 힙이어야 하는 건 X, 스택에 저장될 수도 있다.
    //                :: knight2는 스택에 저장된 knight의 메모리주소를 가리키고 있다.

    // stack 영역은 알아서 자동으로 관리된다.
    // heap 영역은 한번 할당되면 별도 조작없이 해제되지 않지만 C#은 자동으로 해준다.


    // class -> REF(참조)
    class Knight
    {
        // 퍼블릭 붙이는 이유 ?
        // 외부에서 호출 가능하도록
        public int hp;
        public int attack;

        // deepcopy
        // 독립 객체를 생성해서 속성값만 복붙하고 리턴한다.
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

    // struct -> 복사 
    struct Mage
    {
        public int hp;
        public int attack;
    }

    
    class Program1
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main1(string[] args)
        {
            // 객체생성 
            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
            KillKnight(knight); // knight 변수를 직접 참조하여 함수 실행한다


            // 복사(값)과 참조
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage); // 값을 복사해서 함수를 실행한다
            // KillMage(ref mage); -> mage 변수 자체를 접근해서 함수를 실행한

            Mage mage2 = mage; // mage와 mage2는 서로 다른 객체를 가리키고 있다.
            mage2.hp = 0;

            Knight knight2 = knight; // knight와 knight2는 같은 객체를 가리키고 있다.
            knight2.hp = 0;

            // knight, knight3를 서로 다른 객체로 만들려면 ?
            // 처음부터 새로 만든 다음에 속성값을 같게 준다.
            Knight knight3 = new Knight(); // 이 시점에서 독립된 개체
            knight3.hp = knight.hp;
            knight3.attack = knight.attack;

            Knight knight4 = knight.Clone(); // deepcopy, 서로 독립적인 객체.
            knight4.hp = 12;

            Console.WriteLine($"{knight.hp} / {knight2.hp} / {knight4.hp}");

        }
    }
}
