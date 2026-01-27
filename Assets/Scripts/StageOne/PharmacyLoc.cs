using UnityEngine;
using UnityEngine.UI;
using game.stageone;

public class PharmacyLocation : location
{
    protected override void OnItemPicked(Button item)
    {
        Debug.Log("Picked something in the Pharmacy Location!");
    }
}
