using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GM_ToolBox.ExtraFiles.Enums;

namespace GM_ToolBox.ExtraFiles.Parsing
{
    class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public bool IsMagical { get; set; }
        public Rarity Rarity { get; set; }
        public string Description { get; set; }

        private Rarity GetRarity(bool isMagical)
        {
            Rarity result;
            Random rando = new Random();
            int x = rando.Next(1, 101);
            if(!isMagical)
            {
                if(x < 50)
                {
                    if(x/2 < 15)
                    {
                        result = ;
                    }
                }
            }
        }
    }
}
