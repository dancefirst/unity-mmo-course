using System;
using System.Collections.Generic;

namespace OtherUsefulThings1
{
    class Program1
    {
        // 커스텀 리스트에서 모든 자료형을 일반화 하는 처리 
        class MyList<T>
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class MyListMultiple<T,K>
        {

        }

        class MyList2<T> where T : struct
        {

        }

        // 어떤 인자도 안 받는 기본 생성자일 것 
        class MyList3<T> where T : new()
        {

        }

        // 몬스터 또는 몬스터 클래스 상속받은 것만 .
        class MyListMonster<T> where T : Monster
        {

        }

        class Monster
        {

        }

        static void Test<T>(T input)
        {

        }


        static void Main1(string[] args)
        {

            // var - 컴파일러가 오토캐스팅
            var obj_var = 3; // int type
            var str_var = "hello"; // string type

            // object - 오토캐스팅 되지 않은 오브젝트 타입 !
            // 근데 속도가 느리다 ! -> 참조 타입으로만 돌아간다 (힙에 원본 , 스택에 메모리주소)
            // 일반 자료형을 사용하면 스택에서 바로바로 꺼내쓸 수 있어서 빠르다.
            object obj = 3;
            object obj2 = "hello world";

            int num = (int)obj;
            string str = (string)obj2;


            //
            MyList<int> myIntList = new MyList<int>();
            MyList<short> myShortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();


        }
    }
}
