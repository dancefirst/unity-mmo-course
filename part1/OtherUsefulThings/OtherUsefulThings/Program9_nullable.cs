using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace OtherUsefulThings
{
    
    class Program
    {

        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int id { get; set; }
        }


        static void Main(string[] args)
        {
            // Nullable
            int? number = 5;

            // number가 null이 아니라면 Value로 뽑아온 값을 할당하고
            // number가 null이라면 0을 할당한다.
            int b = number ?? 0;

            // 삼항 연산자
            int c = (number != null) ? number.Value : 0;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }


            Monster monster = null;

            if (monster != null)
            {
                int monsterId = monster.id;
            }

            // 물음표를 써서 표시한다 Nullable.
            // .Value -> 변종 짧은 문법.
            int? id = monster?.id;

            if (monster == null)
            {
                id = null;
            }
            else
            {
                id = monster.id;
            }
            
        }
    }
}
