using UnityEngine;
using UnityEngine.UI;

public class Trackdays : MonoBehaviour
{
    public int numDay;
    public Text Days;

    void Start()
    {
        numDay = 1;
    }

    [ContextMenu("Next Day")]
    public void AddDay()
    {
        numDay += 1;
        Days.text = numDay.ToString();
    }
}
