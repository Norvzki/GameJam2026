
using UnityEngine;
using System;

public class SickScript
{
    double cured;
    double death;
    double remain;

    double pchange;
    int days;

    public SickScript()
    {
        cured = 11.0;
        death = 39.0;
        pchange = 1.375;
        days = 0;
    }

    public void chance(Person person)
    {
        float rng = UnityEngine.Random.value * 100;

        if (rng < cured)
        {
            person.isSick = false;
            days = 0;
            cured = 11.0;
            death = 39.0;
            
        }
        else if (rng < cured + death)
        {
            person.isAlive = false;
        }
        else
        {
            days++;
            if (days == 8)
            {
                person.isAlive = false;
                return;
            }

            cured -= pchange; 
            death += pchange;
        }
        


    }


}
