using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.TextRPG2_my
{
    enum CreatureType
    {
        None =0,
        Player = 1,
        Monster =2,
    }
    internal class Creature
    {
        CreatureType type = CreatureType.None;
        protected int hp = 0;
        protected int attack = 0;

        protected Creature(CreatureType type)
        {
            this.type = type;
        }
        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }
        public int OnDamage(int damage)
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
            return hp;
        }
        protected void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }
    }
}
