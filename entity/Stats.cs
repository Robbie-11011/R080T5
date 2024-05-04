using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RobotsTests.entity
{
	public class Stats
	{
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }

        public int MaxHp { get; set; }
        public int BaseAtk { get; set; }
        public int BaseDef { get; set; }

        public Stats()
        {
            MaxHp = 100;
            BaseAtk = 1;
            BaseDef = 1;

            Hp = MaxHp;
            Atk = BaseAtk;
            Def = BaseDef;
        }        
        
        public Stats(int hp, int atk, int def)
        {
            MaxHp = hp;
            BaseAtk = atk;
            BaseDef = def;

            Hp = MaxHp;
            Atk = BaseAtk;
            Def = BaseDef;
        }
    }
}
