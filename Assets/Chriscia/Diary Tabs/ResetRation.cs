using UnityEngine;
using UnityEngine.UI;

public class RationPanel : MonoBehaviour
{
    [Header("Father")]
    public Toggle fatherFood;
    public Toggle fatherWater;
    public Toggle fatherAid;

    [Header("Mother")]
    public Toggle motherFood;
    public Toggle motherWater;
    public Toggle motherAid;

    [Header("Ate")]
    public Toggle ateFood;
    public Toggle ateWater;
    public Toggle ateAid;

    [Header("Kuya")]
    public Toggle kuyaFood;
    public Toggle kuyaWater;
    public Toggle kuyaAid;

    public void ResetAll()
    {
        fatherFood.isOn = false;
        fatherWater.isOn = false;
        fatherAid.isOn = false;

        motherFood.isOn = false;
        motherWater.isOn = false;
        motherAid.isOn = false;

        ateFood.isOn = false;
        ateWater.isOn = false;
        ateAid.isOn = false;

        kuyaFood.isOn = false;
        kuyaWater.isOn = false;
        kuyaAid.isOn = false;
    }
}
