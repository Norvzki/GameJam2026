
using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Security.Cryptography.X509Certificates;
using System;

public class ifSick
{
    double cured;
    double death;
    double remain;

    double pchange;
    int days;

    public ifSick()
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
