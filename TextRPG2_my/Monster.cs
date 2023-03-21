using Csharp.TextRPG2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.TextRPG2_my
{
    enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3,
    }
    class Monster : Creature
    {
        private MonsterType type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            this.type = type;
        }
    }
    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            Console.WriteLine("슬라임 발견");
            SetInfo(20, 2);

        }
    }
    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            Console.WriteLine("오크 발견");
            SetInfo(50, 7);
        }
    }
    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            Console.WriteLine("스켈레톤 발견");
            SetInfo(35, 10);
        }
    }
}
