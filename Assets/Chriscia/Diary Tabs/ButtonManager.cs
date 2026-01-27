using UnityEngine;

public class DiaryButtonManager : MonoBehaviour
{
    private DiaryTab current;

    public void Select(DiaryTab tab)
    {
        if (current == tab) return;

        if (current != null)
            current.Deselect();

        current = tab;
        current.Select();
    }
}
