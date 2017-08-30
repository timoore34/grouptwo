using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM_ToolBox.ExtraFiles.Enums
{
    [Serializable]
    public enum Weapons
    {
        Club_SMW,
        Dagger_SMW,
        Greatclub_SMW,
        Handaxe_SMW,
        Javelin_SMW,
        Light_Hammer_SMW,
        Mace_SMW,
        Quarterstaff_SMW,
        Sickle_SMW,
        Spear_SMW,
        Unarmed_Strike_SMW,
        Light_Crossbow_SRW,
        Dart_SRW,
        Shortbow_SRW,
        Sling_SRW,
        Battleaxe_MMW,
        Flail_MMW,
        Glaive_MMW,
        Greataxe_MMW,
        Greatsword_MMW,
        Halberd_MMW,
        Lance_MMW,
        Longsword_MMW,
        Maul_MMW,
        Morningstar_MMW,
        Pike_MMW,
        Rapier_MMW,
        Scimitar_MMW,
        Shortsword_MMW,
        Trident_MMW,
        War_Pick_MMW,
        Warhammer_MMW,
        Whip_MMW,
        Blowgun_MRW,
        Hand_Crossbow_MRW,
        Heavy_Crossbow_MRW,
        Longbow_MRW,
        Net_MRW
    }
    public static class WeaponExtention
    {
        public static string WeaponToString(this Weapons weapon)
        {
            return weapon.ToString().Remove(weapon.ToString().Length - 4, 4).Replace("_", " ");
        }
        public static string WeaponToType(this Weapons weapon)
        {
            return weapon.ToString().Remove(0, weapon.ToString().Length - 3);
        }
    }
}
