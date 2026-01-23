using System;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;

public class Person
{
   string name;
   float hunger = 100;
   float thirst = 100;
   float mentalState = 100;
   public bool isSick = false;
   public bool isAlive = true;

   public Person (string name)
    {
        this.name = name;
    }
    public void hunger_lvl (bool value)
    {
        if (!value)
        {
            hunger = Math.Max(0, hunger - 10);
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

    public void checkStatus(ifSick condition)
    {
        if (hunger == 0 && thirst == 0)
        {
            isAlive = false;
        } else if (isSick)
        {
            condition.chance(this);
        }
    }

    


}

