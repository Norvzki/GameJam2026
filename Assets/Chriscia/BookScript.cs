using UnityEngine;
using UnityEngine.UI;

public class BookScript : MonoBehaviour
{
    [SerializeField] private GameObject diaryPanel;
    [SerializeField] private Button bookButton;

    [SerializeField] private DiaryButtonManager buttonManager;
    [SerializeField] private DiaryTab logTab;

    public void OnButtonClick()
    {
        diaryPanel.SetActive(true);
        bookButton.gameObject.SetActive(false);
        buttonManager.Select(logTab);
    }
}
