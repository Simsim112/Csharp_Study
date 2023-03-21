using System;

namespace Csharp.TextRPG2
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }
    class Player : Creature
    {
        protected PlayerType type = PlayerType.None; //멤버변수 구분위해서 앞에 _를 붙여서 구분하기도 한다 


        protected Player(PlayerType type) : base(CreatureType.Player)   //바로 플레이어 접근 아니라 Knight이런걸로 만들어라
        {
            this.type = type;
        }

        public PlayerType GetPlayerType() { return type; }
       
    }

    class Knight : Player 
    { 
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);

        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
