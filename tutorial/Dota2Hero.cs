using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Dota2Hero 
    {
        public string hero_name;
        public string hero_attribute;
        public int hero_movespeed;
        public float hero_magical_defense;
        public float receiveMagicDmg (float dmg)
        {
            if (dmg < 0)
            {
                Console.WriteLine("Invalid damage receive");
                return 0;
            } 
            else
            {
                return dmg - (dmg * hero_magical_defense);
            }
        }

        //create a class Constructor for the dota2Hero class

        public Dota2Hero()
        {
            hero_name = string.Empty;
            hero_attribute = "Strength";
            hero_movespeed = 300;
            hero_magical_defense = 0.25F;
        }
    }
}
