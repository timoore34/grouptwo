using GM_ToolBox.ExtraFiles.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GM_ToolBox.ExtraFiles.Parsing
{
    [Serializable]
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
        private int baseHeight;
        private int heightMod;
        private int baseWeight;
        private string weightMod;
        private string size;
        private int speed;
        private int darkvision;
        private List<Weapons> racialWeaponPro;
        private List<Tools> racialToolPro;
        private List<Languages> racialLanguagesPro;
        private List<Armor> racialArmorPro;
        private List<Skills> racialSkillPro;
        private List<string> extraTraits;
        private List<string> maleNames;
        private List<string> femaleNames;
        private List<string> familyNames;
        private bool specialAbilities;
        public Race(int strBonus, int dexBonus, int conBonus, int intBonus, int wisBonus, int chaBonus, int minAdultAge, int maxAge, int baseHeight, int heightMod, int baseWeight, string weightMod, string size, int speed, int darkvision, List<Weapons> racialWeaponPro, List<Tools> racialToolPro, List<Languages> racialLanguagesPro, List<Armor> racialArmorPro, List<Skills> racialSkillPro, List<string> extraTraits, List<string> maleNames, List<string> femaleNames, List<string> familyNames, bool specialAbilities) : this()
        {
            StrBonus = strBonus;
            DexBonus = dexBonus;
            ConBonus = conBonus;
            IntBonus = intBonus;
            WisBonus = wisBonus;
            ChaBonus = chaBonus;
            MinAdultAge = minAdultAge;
            MaxAge = maxAge;
            BaseHeight = baseHeight;
            HeightMod = heightMod;
            BaseWeight = baseWeight;
            WeightMod = weightMod;
            Size = size;
            Speed = speed;
            Darkvision = darkvision;
            RacialWeaponPro = racialWeaponPro;
            RacialToolPro = racialToolPro;
            RacialLanguagesPro = racialLanguagesPro;
            RacialArmorPro = racialArmorPro;
            RacialSkillPro = racialSkillPro;
            ExtraTraits = extraTraits;
            MaleNames = maleNames;
            FemaleNames = femaleNames;
            FamilyNames = familyNames;
            SpecialAbilities = specialAbilities;
        }
        public int StrBonus { get => strBonus; set => strBonus = value; }
        public int DexBonus { get => dexBonus; set => dexBonus = value; }
        public int ConBonus { get => conBonus; set => conBonus = value; }
        public int IntBonus { get => intBonus; set => intBonus = value; }
        public int WisBonus { get => wisBonus; set => wisBonus = value; }
        public int ChaBonus { get => chaBonus; set => chaBonus = value; }
        public int MinAdultAge { get => minAdultAge; set => minAdultAge = value; }
        public int MaxAge { get => maxAge; set => maxAge = value; }
        public int BaseHeight { get => baseHeight; set => baseHeight = value; }
        public int HeightMod { get => heightMod; set => heightMod = value; }
        public int BaseWeight { get => baseWeight; set => baseWeight = value; }
        public string WeightMod { get => weightMod; set => weightMod = value; }
        public string Size { get => size; set => size = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Darkvision { get => darkvision; set => darkvision = value; }
        public List<Weapons> RacialWeaponPro { get => racialWeaponPro; set => racialWeaponPro = value; }
        public List<Tools> RacialToolPro { get => racialToolPro; set => racialToolPro = value; }
        public List<Languages> RacialLanguagesPro { get => racialLanguagesPro; set => racialLanguagesPro = value; }
        public List<Armor> RacialArmorPro { get => racialArmorPro; set => racialArmorPro = value; }
        public List<Skills> RacialSkillPro { get => racialSkillPro; set => racialSkillPro = value; }
        public List<string> ExtraTraits { get => extraTraits; set => extraTraits = value; }
        public List<string> MaleNames { get => maleNames; set => maleNames = value; }
        public List<string> FemaleNames { get => femaleNames; set => femaleNames = value; }
        public List<string> FamilyNames { get => familyNames; set => familyNames = value; }
        public bool SpecialAbilities { get => specialAbilities; set => specialAbilities = value; }
    }
    public class RaceParsing
    {
        private const string location = "BackgroundData/RaceDataFile.rce";
        public RaceParsing()
        {

        }
    }
}