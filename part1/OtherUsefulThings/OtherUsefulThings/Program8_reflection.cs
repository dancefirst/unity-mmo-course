using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace OtherUsefulThings8
{

    class Monster
    {

        class Important : System.Attribute
        {
            string message;

            public Important(string message) { this.message = message; }
        }

        // hp 입니다. 중요한 정보입니다.
        [Important("Very Important")]
        public int hp;

        protected int attack;
        private float speed;

        void Attack() { }
    }

    class Program8
    {


        static void Main8(string[] args)
        {
            // Reflection? -> 엑스레이를 찍는 것 !

            Monster monster = new Monster();
            Type type = monster.GetType(); // 클래스의 요모조모 정보들을 모두 빼낼 수 있다!

            var fields = type.GetFields(System.Reflection.BindingFlags.Public
                |System.Reflection.BindingFlags.NonPublic
                |System.Reflection.BindingFlags.Static
                |System.Reflection.BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";


                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
            }            

        }
    }
}
