
using UnityEditor.Search;
using UnityEngine;
using game.Items;
using System;

namespace game.questItems
{
    public class Toolbox : Usable
    {
        game.Items.Usable tool;
        public Toolbox(game.Items.Usable a) 
        {
            weight = 3;
            durability = 3;
            maxDurability = 3;
            tool = a;

        }

        public override void function()
        {
            if (tool != null)
            {
                tool.Repair();  
            }
        }
    }

    public class Radio : Usable
    {
        public Radio()
        {
            weight = 2;
            durability = 2;
            maxDurability = 2;

        }

        public override void function()
        {   
            //to be coded along with dialogue and route scenario
        }
        
    }

    public class Sungka : Usable
    {
        public Sungka()
        {
            weight = 1;
            durability = 4;
            maxDurability = 4;

        }

        public override void function()
        {   
            //to be coded along with dialogue and route scenario
        }
        
    }

    public class Cards : Usable
    {
        public Cards()
        {
            weight = 1;
            durability = 3;
            maxDurability = 3;

        }

        public override void function()
        {   
            //to be coded along with dialogue and route scenario
        }

    }

    public class Sundang : Usable
    {   

        public Sundang()
        {
            weight = 1;
            durability = 3;
            maxDurability = 3;
        }

        public void equip()
        {
            //to be coded for expedition
        }
        public override void function()
        {   
            //to be coded with expedition or protection
        }

        
    }

    public class Raincoat : item
    {
        public Raincoat()
        {
            weight = 2;
            durability = 3;
        }

        public void equip()
        {
            //to be coded for expedition
        }
        public override void function()
        {   
            //to be coded for expedition
        }
        public override void useItem ()
        {
            if (durability != 0)
            {
                function();
                durability -= 1;
            }
        }
        
    }

    public class Flashlight : item
    {
        public Flashlight()
        {
            weight = 1;
            durability = 3;
        }

        public void equip()
        {
            //to be coded for expedition
        }
        public override void function()
        {   
            //to be coded for expedition
        }
        public override void useItem ()
        {
            if (durability != 0)
            {
                function();
                durability -= 1;
            }
        }
        
    }


}