using UnityEditor.Toolbars;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUpdate : MonoBehaviour
{
    [SerializeField] protected CanvasGroup memberUI;

    public Person Member;
    [Header("Expedition")]
    public bool onExpedition;

    [Header("UI")]
    public Toggle aid_toggle;
    public Toggle expedition_toggle;

    private bool giveFood;
    private bool giveWater;
    private bool giveAid;

    public void SetFood(bool value)
    {
        giveFood = value;
    }

    public void SetWater(bool value)
    {
        giveWater = value;
    }

    public void SetAid(bool value)
    {
        giveAid = value;
    }

    public void SetExpedition(bool value)
    {
        onExpedition = value;
    }

    public void UpdateUI(bool value)
    {   
        if (value)
        {
            memberUI.alpha = 1;
        }
        else
        {
            memberUI.alpha = 0;
        }
        
        memberUI.interactable = value;
        memberUI.blocksRaycasts = value;
        expedition_toggle.gameObject.SetActive(value);
        gameObject.SetActive(value);
    }



    public void ResolveDay()
    {
        if (onExpedition)
        {

            Member.hunger -= 5;
            Member.thirst -= 5;
        }

        Member.hunger_lvl(giveFood);
        Member.thirst_lvl(giveWater);

        if (Member.isSick)
        {
            aid_toggle.gameObject.SetActive(true);
            aid_toggle.interactable = true; // if condition && they have med kit
            Member.isSick = !giveAid;
        }
        else
        {
            aid_toggle.gameObject.SetActive(false);
        }

        Member.checkStatus();
        
        giveFood = giveWater = giveAid = false;

    }
}