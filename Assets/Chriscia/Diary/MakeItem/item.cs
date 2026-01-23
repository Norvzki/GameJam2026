using UnityEngine;
using System;

namespace game.Items
{
    public abstract class item
    {
        protected int weight;
        protected double durability;
        public abstract void function();
        public abstract void useItem();
    }

    public abstract class Usable : item
    {
        protected double sRate = 100;
        protected double maxDurability;
        public bool successRate()
        {
            float rng = UnityEngine.Random.value * 100;
            if (rng < sRate)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public virtual void Repair()
        {
            if (durability < maxDurability)
            {
                durability += 1;
            }
        }

        public override void useItem ()
        {
        
            if (durability != 0 && successRate())
            {
                function();
                durability -= 1;
                sRate -= 15;
            }else if (durability != 0)
            {
                durability -= 1;
                sRate -= 15;
            }
            
        }
    }
}



