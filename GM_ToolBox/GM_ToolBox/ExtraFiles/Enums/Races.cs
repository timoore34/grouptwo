using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM_ToolBox.ExtraFiles.Enums
{
    [Serializable]
    public enum Races
    {
        Hill_Dwarf,
        Mountain_Dwarf,
        High_Elf,
        Wood_Elf,
        Dark_Elf,
        Lightfoot_Halfling,
        Stout_Halfling,
        Human,
        Dragonborn,
        Forest_Gnome,
        Rock_Gnome,
        Half_Elf,
        Half_Orc,
        Tiefling
    }
    public static class RaceExtention
    {
        public static string RaceToString(this Races race)
        {
            return race.ToString().Replace("_", " ");
        }
        public static Races StringToRace(this string race)
        {
            return (Races)Enum.Parse(typeof(Races), race.Replace(" ", "_"));
        }
    }
}
