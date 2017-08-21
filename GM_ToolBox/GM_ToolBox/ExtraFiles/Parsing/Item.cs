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
        string name, description;
        int value;
        bool magical;

        public Item(string name, int value, bool magical, string description)
        {
            Name = name;
            Value = value;
            IsMagical = magical;
            Description = description;
        }

        public string Name { get; set; }
        public int Value { get; set; }
        public bool IsMagical { get; set; }
        public Rarity Rarity { get; set; }
        public string Description { get; set; }
        

        private Rarity GetRarity(bool isMagical)
        {
            Rarity result = Rarity.Trash;
            Random rando = new Random();
            int x = rando.Next(1, 101);
            if(!isMagical)
            {
                if(x < 50)
                {
                    if(x/2 < 15)
                    {
                       
                    }
                }
            }
            return result;
        }

        public string toString()
        {
            return ("Item:\t" + Name
                + "\nValue:\t" + Value
                + "\nMagicaly Inbued:\t" + IsMagical
                + "\nDescription: " + Description
                );
        }

    }
}
