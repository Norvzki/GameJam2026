using UnityEngine;
using UnityEngine.UI;

public class Book : DiaryTab
{
    [SerializeField] private GameObject diaryPanel;
    [SerializeField] private Button bookButton;

    public void OnButtonClick()
    {
        diaryPanel.SetActive(true);
        bookButton.gameObject.SetActive(false);

    }
}
