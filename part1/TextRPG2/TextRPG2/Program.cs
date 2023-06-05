using System;

namespace TextRPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Player player = new Player();

            Game game = new Game();

            while (true)
            {
                game.Process();
            }

            // 게임스테이지 등도 객체로 만들어 관리할 수 있다 !
            //Player player = new Knight();
            //Player player2 = new Archer();
            //Monster monster = new Orc();

            //int damage = player.GetAttack();
            //monster.OnDamaged(damage);
            //player2.OnDamaged(damage);
        }
    }
}
