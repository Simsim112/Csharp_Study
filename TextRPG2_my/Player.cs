using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.TextRPG2_my
{
    enum playerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3,
    }
    class Player : Creature
    {
        private playerType type = playerType.None;

        protected Player(playerType type) : base(CreatureType.Player)
        {
            this.type = type;
        }

    }
    class Knight : Player
    {
        public Knight() : base(playerType.Knight)
        {
            base.SetInfo(75, 12);

        }
    }
    class Archer : Player
    {
        public Archer() : base(playerType.Archer)
        {
            base.SetInfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(playerType.Mage)
        {
            base.SetInfo(75, 12);
        }
    }
}
