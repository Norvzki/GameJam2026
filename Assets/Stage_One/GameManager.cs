using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int dialogue = 0;
    public TMP_Text mainText;
    public Button backbutton;
    public Button nextbutton;
    void Start()
    {
        nextbutton.onClick.AddListener(nextClicked);
        backbutton.onClick.AddListener(backClicked);
    }

    void UpdateDialouge()
    {
        switch (dialogue)
        {
            case 1:
                mainText.text = "To survive, you've got to carefully plan out your survival.";
                nextbutton.GetComponentInChildren<TMP_Text>().text = "Start";
                break;
            case 2:
                break;
            default:
                mainText.text = "Game Mechanics: Try to get as much items as you can! Don't forget for check out.";
                nextbutton.GetComponentInChildren<TMP_Text>().text = "Next";
                break;
        }
    }
    void backClicked()
    {
        if(dialogue > 0)
        {
            dialogue--;
            UpdateDialouge();
        }
    }
    void nextClicked()
    {
        if (dialogue < 1)
        {
            dialogue++;
            UpdateDialouge();
        } else if (dialogue == 1)
        {
            SceneManager.LoadScene("StageOne_Part2");
        }
    }

}
