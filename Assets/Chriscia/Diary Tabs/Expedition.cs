using Unity.XR.GoogleVr;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class Expedition : MonoBehaviour
{
    //on click, an expedition is set for the next day 
    [SerializeField] public Toggle Bag;
    [SerializeField] protected CanvasGroup content;
    public  bool expePlanned;
    public CharacterUpdate chosenMember;

    public int expeditionStartDay;
    public int expeditionDuration;


    private void Awake()
    {
        Bag.gameObject.SetActive(false);
        HideMemberUI();
    }

    private void HideMemberUI()
    {
        content.alpha = 0;
        content.interactable = false;
        content.blocksRaycasts = false; 
    }

    public void onSelect(bool value)
    {
        expePlanned = value;

    }

    public void SendMemberUI(Family family)
    {
        Bag.gameObject.SetActive(false);

        content.alpha = 1;
        content.interactable = true;
        content.blocksRaycasts = true;

        ShowToggle(family.Father);
        ShowToggle(family.Mother);
        ShowToggle(family.Ate);
        ShowToggle(family.Kuya);
    }

    private void ShowToggle(CharacterUpdate member)
    {
        if(member.Member.isAlive) member.expedition_toggle.gameObject.SetActive(true);
        
    }

    public void InProgress(CharacterUpdate member, int currentDay)
    {   
        if (!member.onExpedition) return;
        

        //after rng amount of days, the member.chooseExpedition and ExpeValue will reset
        chosenMember = member;
        expeditionStartDay = currentDay;
        expeditionDuration = Random.Range(2, 4);

        chosenMember.UpdateUI(false);

        HideMemberUI();
        expePlanned = false;
    }

    public void CheckExpeditionReturn(int currentDay)
    {
        if (chosenMember == null) return;

        if (currentDay > (expeditionStartDay + expeditionDuration + 2))
        {
            chosenMember.onExpedition = false;
            chosenMember.gameObject.SetActive(true);

            chosenMember = null;
            expeditionDuration = 0;
            expeditionStartDay = 0;

            Bag.isOn = false;
            Bag.gameObject.SetActive(true);
        }
    }


    
    





}
