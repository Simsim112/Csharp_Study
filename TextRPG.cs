namespace Csharp
{
   /* internal class TextRPG
    {
        enum Job
        {
            None,
            knight,
            Archer,
            Wizard,
        }
        enum ememy
        {
            Slime,
            Orc,
            Skeleton,
        }
        struct Player
        {
            public int hp;
            public int attack;
        }
        struct Monster
        {
            public int hp;
            public int attack;
        }
        //클래스 선택
        static Job JobChoice()
        {
            Console.WriteLine("클래스를 선택해주세요");
            Console.WriteLine($"[{(int)Job.knight}] {Job.knight}");
            Console.WriteLine($"[{(int)Job.Archer}] {Job.Archer}");
            Console.WriteLine($"[{(int)Job.Wizard}] {Job.Wizard}");

            Job choice = Job.None;
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case (int)Job.knight:
                    choice = Job.knight;
                    break;
                case (int)Job.Archer:
                    choice = Job.Archer;
                    break;
                case (int)Job.Wizard:
                    choice = Job.Wizard;
                    break;
                default:
                    break;
            }
            return choice;
        }
        //플레이어 생성
        static void CreatePlayer(Job choice, out Player player)
        {
            switch (choice)
            {
                case Job.knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case Job.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case Job.Wizard:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }
        //랜덤 몬스터 생성
        static void CreateMonster(out Monster monster)
        {
            Random rand = new Random();
            int monster_num = rand.Next(0, 3);

            switch (monster_num)
            {
                case (int)ememy.Slime:
                    Console.WriteLine("슬라임을 만났습니다.");
                    monster.hp = 20;
                    monster.attack = 1;
                    break;
                case (int)ememy.Orc:
                    Console.WriteLine("오크를 만났습니다.");
                    monster.hp = 40;
                    monster.attack = 3;
                    break;
                case (int)ememy.Skeleton:
                    Console.WriteLine("스켈레톤을 만났습니다.");
                    monster.hp = 30;
                    monster.attack = 2;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }
        //전투
        static void Fight(ref Player player, Monster monster)
        {
            while (true)
            {
                //player턴
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("승리하셨습니다.");
                    Console.WriteLine($"남은 체력 : {player.hp}");
                    break;
                }

                //monster턴
                player.hp -= player.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("패배하셨습니다.");
                    break;
                }
            }
        }
        static void EnterFiled(ref Player player)
        {
            Console.WriteLine("필드에 입장하셨습니다!");

            //랜덤 몬스터 생성
            Monster monster;
            CreateMonster(out monster);

            Console.WriteLine("[1] 싸우기");
            Console.WriteLine("[2] 도망가기");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Fight(ref player, monster);
                    break;
                case "2":
                    Random rand = new Random();
                    int run = rand.Next(0, 101);
                    if (run <= 33)
                    {
                        Console.WriteLine("도망쳤습니다.");
                    }
                    else
                    {
                        Fight(ref player, monster);
                    }
                    break;
            }
        }
        //게임입장
        static void EnterGame(ref Player player)
        {
            Console.WriteLine("게임에 접속하셨습니다!");
            while (true)
            {
                Console.WriteLine("[1] 필드로 가기");
                Console.WriteLine("[2] 로비로 가기");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        EnterFiled(ref player);
                        break;
                    case "2":
                        return;
                }
            }
        }
        static void Main()
        {

            while (true)
            {
                Job choice = JobChoice();
                if (choice == Job.None)
                    continue;

                Player player;
                CreatePlayer(choice, out player);
                EnterGame(ref player);
            }
        }
    }*/
}
