using UnityEngine;
using UnityEngine.UI;
using game.stageone;

public class MarketLocation: location
{
    protected override void OnItemPicked(Button item)
    {
        Debug.Log("Picked something in the Market Location!");
    }
}
