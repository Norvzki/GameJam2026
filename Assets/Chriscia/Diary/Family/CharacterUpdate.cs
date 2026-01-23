using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUpdate : MonoBehaviour
{
   public Person Member;

    public void Hunger(Toggle toggle)
    {
        bool value = toggle.isOn;
        Debug.Log("Button state is now: " + value);
        Member.hunger_lvl(value);

    }
    
    public void Thirst(Toggle toggle)
    {
        bool value = toggle.isOn;
        Debug.Log("Button state is now: " + value);
        Member.thirst_lvl(value);
    }


    public void Aid(Toggle toggle)
    {
        bool value = toggle.isOn;
        Member.isSick = !value;
        Debug.Log("Button state is now: " + value);

    }


}
