using GM_ToolBox.ExtraFiles.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM_ToolBox.ExtraFiles.Parsing
{
    public struct Race
    {
        private int strBonus;
        private int dexBonus;
        private int conBonus;
        private int intBonus;
        private int wisBonus;
        private int chaBonus;
        private int minAdultAge;
        private int maxAge;
        private float baseHeight;
        private int heightMod;
        private int baseWeight;
        private float weightMod;
        private string size;
        private int speed;
        private int darkvision;
        private List<Weapons> racialWeaponPro;
    }
    class RaceParsing
    {
        private Races ?race = null;
        public RaceParsing()
        {
        }
    }
}
