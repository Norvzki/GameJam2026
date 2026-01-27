using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class MotorcycleSequence : MonoBehaviour
{
    int dialogue = 0;
    public Timer timer;
    public Button[] messages;
    public Image[] motorImages;
    public GameObject main, start, timerText;
    void Start()
    {
        foreach (Button b in messages)
        {
            b.onClick.AddListener(() => ButtonClicked(b));
        }

        foreach (Image img in motorImages)
        {
            img.gameObject.SetActive(false);
        }

        StartCoroutine(StartSequence());
    }

    IEnumerator StartSequence()
    {
        foreach (Button b in messages)
            b.interactable = false;

        yield return new WaitForSeconds(2f);

        foreach (Button b in messages)
            b.interactable = true;

        motorImages[0].gameObject.SetActive(true);
        UpdateDialouge();
    }
    void UpdateDialouge()
    {
        motorImages[dialogue].gameObject.SetActive(true);
        messages[dialogue].gameObject.SetActive(true);
        motorImages[dialogue-1].gameObject.SetActive(false);
        messages[dialogue-1].gameObject.SetActive(false);
    }
    void ButtonClicked(Button b)
    {
        if (dialogue < 4)
        {
            dialogue++;
            UpdateDialouge();
        }
        else if (dialogue == 4)
        {
            main.gameObject.SetActive(false);
            start.gameObject.SetActive(true);
            timerText.gameObject.SetActive(true);
            timer.StartTimer();

        }
    }

}
