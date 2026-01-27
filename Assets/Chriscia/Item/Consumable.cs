using UnityEditor.Search;
using UnityEngine;
using game.Items;
using System;

namespace game.consumables
{
    public class Food : item
{
    Person person;
    public Food(Person a)
        {
            weight = 1;
            durability = 1;
            person = a;
        
        }

    public override void function()
        {
            person.hunger_lvl(true);
        }
    public override void useItem ()
        {
            if (durability != 0)
            {
                function();
                durability -= 0.5;
            }
        }

}
public class Water : item
{
    Person person;
    public Water(Person a)
        {
            weight = 2;
            durability = 4;
            person = a;
        
        }

    public override void function()
        {
            person.thirst_lvl(true);
        }
    public override void useItem ()
        {
            if (durability != 0)
            {
                function();
                durability -= .5;
            }
        }

}

public class Medkit : item
{
    Person person;
    public Medkit(Person a)
        {
            weight = 1;
            durability = 1;
            person = a;
        
        }

    public override void function()
        {
            person.isSick = false;
        }
    public override void useItem ()
        {
            if (durability != 0)
            {
                function();
                durability -= 0;
            }
        }

}
}

