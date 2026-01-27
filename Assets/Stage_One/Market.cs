using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class Market : MonoBehaviour
{
    int itemsLeft = 3;
    public Button Food_1, Food_2, Medkit_1;

    void Start()
    {
        Food_1.onClick.AddListener(() => clicked(Food_1));
        Food_2.onClick.AddListener(() => clicked(Food_2));
        Medkit_1.onClick.AddListener(() => clicked(Medkit_1));
    }
    void clicked(Button item)
    {
        item.gameObject.SetActive(false);
        itemsLeft--;
        if (itemsLeft == 0)
        {
            SceneManager.LoadScene("StageOne_Part1");
        }
    }
}
