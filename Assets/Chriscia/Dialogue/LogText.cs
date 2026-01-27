using UnityEngine;
using System.IO;
using TMPro;

public class LogText 
{
    [SerializeField] public TextMeshProUGUI Logtxt;

    public void PrintDialogue(CharacterUpdate member, GetstatusLine status, int currentDay)
    {

        string path = Path.Combine(Application.dataPath, "Chriscia", "Dialogue","DailyLog.txt");
        string [] lines = File.ReadAllLines(path);

        if (currentDay < 5)
        {
            switch (currentDay)
            {
                case 1:
                    Logtxt.text = lines[0];
                    return;
                case 2:
                    Logtxt.text = lines[1];
                    return;
                case 3: 
                    Logtxt.text = lines[2];
                    return;
                case 4:
                    Logtxt.text = lines[3];
                    return;
                case 5:
                    Logtxt.text = lines[4];
                    return;
                default: 
                    return;

                    

            }
        }
    }
}
