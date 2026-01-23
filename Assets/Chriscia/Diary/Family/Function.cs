using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class function : MonoBehaviour
{
    
    public bool value = false;

    public void OnButtonClick()
    {
        value = !value;
        Debug.Log("Button state is now: " + value);
    }
}