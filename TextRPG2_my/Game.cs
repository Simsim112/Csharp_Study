namespace Csharp.TextRPG2_my
{
    enum Map
    {
        None = 0,
        Lobby = 1,
        Town = 2,
        Field = 3,
    }
    class Game
    {
        Map type = Map.Lobby;
        Player player = null;
        Monster monster = null;
        Random rand = new Random();

        public void Process()
        {
            while (true)
            {
                switch (type)
                {
                    case Map.Lobby:
                        ProcessLobby();
                        break;
                    case Map.Town:
                        ProcessTown();
                        break;
                    case Map.Field:
                        ProcessFiled();
                        break;
                }
            }
        }
        private void ProcessLobby()
        {
            Console.WriteLine("직업을 골라주세요!");
            Console.WriteLine("[1] 전사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    type = Map.Town;
                    break;
                case "2":
                    player = new Archer();
                    type = Map.Town;
                    break;
                case "3":
                    player = new Mage();
                    type = Map.Town;
                    break;
            }
        }
        private void ProcessTown()
        {
            Console.WriteLine("마을에 입장하셨습니다");
            Console.WriteLine("[1] 필드로 가기");
            Console.WriteLine("[2] 로비로 가기");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    type = Map.Field;
                    break;
                case "2":
                    type = Map.Lobby;
                    break;
            }
        }
        private void ProcessFiled()
        {
            CreateRandomMonster();

            Console.WriteLine("[1] 싸운다");
            Console.WriteLine("[2] 도망친다");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Fight();
                    break;
                case "2":
                    Escape();
                    break;
            }
        }
        private void Escape()
        {
            int randValue = rand.Next(0,101);
            if(randValue < 33)
            {
                Console.WriteLine("도망쳤습니다!");
                type = Map.Town;

            }
            else
            {
                Console.WriteLine("도망치는데 실패했습니다!");
                Fight();
            }
        }
        private void Fight()
        {
            while(true)
            {
                int player_attack = player.GetAttack();
                monster.OnDamage(player_attack);
                if (monster.GetHp() <= 0)
                {
                    Console.WriteLine($"승리하셨습니다! 남은 체력 : {player.GetHp()}");
                    break;
                }

                int monster_attack = monster.GetAttack();
                player.OnDamage(monster_attack);

                if (player.GetHp() <= 0)
                {
                    Console.WriteLine("You Die :<");
                    type = Map.Lobby;
                    break;
                }
            }
           
        }
        private void CreateRandomMonster()
        {
            int randValue = rand.Next(1, 4);

            switch (randValue)
            {
                case 1:
                    monster = new Slime();
                    break;
                case 2:
                    monster = new Orc();
                    break;
                case 3:
                    monster = new Skeleton();
                    break;
            }
        }
    }
}
