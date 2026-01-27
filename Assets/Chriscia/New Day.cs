using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using TMPro;
using System.Data.Common;

public class NewDay : MonoBehaviour
{

    public Family family;
    [SerializeField] private GameObject diaryPanel;
    [SerializeField] private Button bookButton;
    [SerializeField] private RationPanel rationPanel;
    [SerializeField] public TextMeshProUGUI dayCount;
    public Expedition expedition;
    public int day = 1;

    
   public bool CheckAlive()
    {
        int dead = 0;
        if (CheckMember(family.Father)) dead++;
        if (CheckMember(family.Mother)) dead++;
        if (CheckMember(family.Ate)) dead++;
        if (CheckMember(family.Kuya)) dead++;

        if (dead == 4) return false;
        return true;
    }

    private bool CheckMember(CharacterUpdate member)
    {
        if (!member.Member.isAlive)
        {
            return false;
        }
        return true;
    }

    public void NextDay()
    {   
        
        day++;
        
        OpenExpedition();
        expedition.CheckExpeditionReturn(day);
 
        ResolveMember(family.Father);
        ResolveMember(family.Mother);
        ResolveMember(family.Ate);
        ResolveMember(family.Kuya);

        diaryPanel.SetActive(false);
        rationPanel.ResetAll();
        bookButton.gameObject.SetActive(true);
        
        dayCount.text = "Day " + day.ToString();

        
        DisplayFamilyStatus();    
    }

    private void ResolveMember(CharacterUpdate member)
    {
        if (!CheckMember(member))
            {
                member.UpdateUI(false);
                return;
            }

        if (expedition.expePlanned)
        {
            expedition.InProgress(member,day);
        }
        member.ResolveDay();
        

    }   

    public void OpenExpedition()
    {
        if (day == 2)expedition.Bag.gameObject.SetActive(true);
        if (expedition.expePlanned) expedition.SendMemberUI(family);
        return;
    }


    public void DisplayFamilyStatus()
    {
        Debug.Log("Father");
        DisplayMemberStatus(family.Father);

        Debug.Log("Mother");
        DisplayMemberStatus(family.Mother);

        Debug.Log("Ate");
        DisplayMemberStatus(family.Ate);

        Debug.Log("Kuya");
        DisplayMemberStatus(family.Kuya);
    }
    
    private void DisplayMemberStatus(CharacterUpdate member)
    {
        Debug.Log($"Hunger: {member.Member.hunger}");
        Debug.Log($"Thirst: {member.Member.thirst}");
        Debug.Log($"Sick: {member.Member.isSick}");
        Debug.Log($"Alive: {member.Member.isAlive}");
    }

}
