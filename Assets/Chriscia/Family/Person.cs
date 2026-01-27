using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Person
{
   string name;
   public int hunger = 100;
   public int thirst = 100;
   public int mentalState = 100;
   public bool isSick = false;
   public bool isAlive = true;

   private SickScript sickness = new SickScript();

   public Person (string name)
    {
        this.name = name;
    }
    public void hunger_lvl (bool value)
    {
        if (!value)
        {
            hunger = Math.Max(0, hunger - 20);
        }
        else
        {
            hunger = 100;
        }
        
    }

    public void thirst_lvl (bool value)
    {
        if (!value)
        {
            thirst = Math.Max(0, thirst - 25);
        }
        else
        {
            thirst = 100;
        }
        
    }

    public void mental_lvl (bool value)
    {
        if (!value)
        {
            mentalState = Math.Max(0, mentalState - 5);
        }
        else
        {
            mentalState = 100;
        }

    }
    
    public void setSick ()
    {
       isSick = true;
    }

    public void checkStatus()
    {
        if (hunger == 0 && thirst == 0)
        {
            isAlive = false;
        } else if (isSick)
        {
            sickness.chance(this);
        }
    }

    


}

