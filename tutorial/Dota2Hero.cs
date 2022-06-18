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

        public void getHeroInfo ()
        {
            Console.WriteLine("This hero's name : " + this.hero_name);
            Console.WriteLine(this.hero_name+ "'s attribute : " + this.hero_attribute);
            Console.WriteLine(this.hero_name+ "'s movespeed : " + this.hero_movespeed);
            Console.WriteLine(this.hero_name+ "'s magical defense : " + this.hero_magical_defense);
            Console.WriteLine("****************************************");
        }
        public float receiveMagicDmg (float dmg)
        {
            if (dmg < 0)
            {
                Console.WriteLine("Invalid damage receive");
                return 0;
            } 
            else
            {
                float true_dmg = dmg - (dmg * hero_magical_defense);
                Console.WriteLine(this.hero_name + " receive "+true_dmg);
                return true_dmg;
            }
        }

        //create a class Constructor for the dota2Hero class

        public Dota2Hero()
        {
            hero_name = "blank";
            hero_attribute = "Strength";
            hero_movespeed = 300;
            hero_magical_defense = 0.25F;
        }

        //create a class Constructor for the dota2Hero class with a parameter
        public Dota2Hero(string name)
        {
            hero_name = name;
            hero_attribute = "Strength";
            hero_movespeed = 300;
            hero_magical_defense = 0.25F;
        }

        //create a class Constructor for the dota2Hero class with multiple parameters
        public Dota2Hero(string name, string attribute, int movespeed, float magic_def)
        {
            hero_name = name;
            hero_attribute = attribute;
            hero_movespeed = movespeed;
            hero_magical_defense = magic_def;
        }

    }
}
