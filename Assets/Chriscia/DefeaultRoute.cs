using UnityEngine;
using UnityEngine.UI;

public class DefaultRoute : MonoBehaviour
{
    public NewDay days;

    //Check days is working
    void Start()
    {
        Debug.Log("Day is: " + days.day);
    }

    public void DefaultCheck()
    {
        if (days != null) {
            Debug.Log("Day is: " + days.day);
        } else
        {
            Debug.Log("Null");
        }
    }

}