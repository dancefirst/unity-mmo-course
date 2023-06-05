using System;
using System.Collections.Generic;

namespace OtherUsefulThings3
{
    class Program3
    {

        // 객체지향 -> 은닉성
        class Knight
        {
            //protected int hp;

            //// hp는 숨겨두고 외부에는 Hp로 접근시킨다.
            //public int Hp
            //{
            //    get { return hp; }
            //    //set { hp = value; }
            //    private set { hp = value; } // 안에서만 사용가능하게 setter를 막아버릴 수도 있다.
            //}

            // 자동구현 프로퍼티 --- 극한의 귀차니즘을 위한 편의기능 !!
            // 초기화 적용까지 가능하다 갓갓 
            public int Hp { get; set; } = 100;


            void Test()
            {
                Hp = 100;
            }

            // Getter, Get 함수 
            //public int GetHP() { return hp; }

            // Setter, Set 함수
            //public void SetHP(int hp) { this.hp = hp; }
        }


        static void Main3(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            //knight.hp = 100;
            //knight.SetHP(100);

            //knight.Hp = 100;
            int hp = knight.Hp;
        }
    }
}
