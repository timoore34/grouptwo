using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM_ToolBox.ExtraFiles.Enums
{
    [Serializable]
    public enum Skills
    {
        Acrobatics,
        Animal_Handling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        Sleight_of_Hand,
        Stealth,
        Survival
    }
    public static class SkillExtention
    {
        public static string SkillToString(this Skills skill)
        {
            return skill.ToString().Replace("_", " ");
        }
    }
}
