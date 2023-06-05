using System;

namespace ObjectedOriented5
{

    // OOP - 은닉성

    // 자동차
    // 핸들 페달 차문열기
        // 전기장치 엔진 기름 화학처리 <-> 외부에 조작가능하게 노출시키면??
        // 개발 협업할 때에도 함수명을 보고 대충 기능을 추정하는 경우가 많다
        // 막 접근해서 쓸 수 있게 할 것인가 아니면 숨길 것인가 -- 중요도에 따른 보안레벨을 설정
        // ---> 객체지향의 3대요소 중 하나인 "은닉성"

    class Knight
    {
        // 접근 한정자
            // public protected private

        // 어디에서나 호출하고 변경가능한 상태 -> public
        //public int hp;

        // 클래스 내부에서 정의된 로직에서만 사용 가능
        // private 필드를 SetHP 메소드 경로를 통해서만 변경 가능하게 했을 때의 장점 ?
        // 에러 등을 추적할 때 훨씬 찾기가 간편해진다 !
        private int hp;
        public void SetHP(int hp)
        {
            this.hp = hp;
        }

        // protected는 기본적으로 private / 상속받은 클래스에서는 접근 가능함 (예외허용)
        protected int hp2;


        //public void SecretFunction()
        //{
        //    hp = 20;
        //}
    }

    class SuperKnight : Knight
    {
        void TestProtected()
        {
            hp2 = 10;
        }
    }

    class Program5
    {
        static void Main5(string[] args)
        {
            Knight knight = new Knight();
            knight.SetHP(10);

        }
    }
}
