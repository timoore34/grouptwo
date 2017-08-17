using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM_ToolBox.ExtraFiles
{
    class CharacterSheet
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int HitDie { get; set; }
        public int Level { get; set; }


        private int GetInitiative(int dexMod, int misc = 0)
        {
            return dexMod + misc;
        }

        private int GetAC(int dexMod, int armor, int shield, int natural = 0, int dodge = 0, int misc = 0)
        {
            return 10 + dexMod + armor + natural + dodge + shield + misc;
        }

        private int GetMaxHP(int level, int hitDie, int conMod)
        {
            int hps = hitDie / 2 + 1;
            return ((hps * level) + (level * conMod));
        }

        private int GetMod(int stat)
        {
            return ((stat - 10) / 2);
        }

        private int GetSkill(bool skill, int profeciency, int statMod)
        {
            return skill ? statMod + profeciency : statMod;
        }
    }
}
