using UnityEngine;
using UnityEngine.UI;
using game.stageone;

public class CashierLocation : location
{
    public Button checkout;
    public override void Start()
    {
        base.Start();
        checkout.onClick.AddListener(() => OnClicked(checkout));
    }
    public void OnClicked(Button b)
    {
        Carried = 0;
        Debug.Log("Succesfully Checked Out!");
    }
    protected override void OnItemPicked(Button item)
    {
        Debug.Log("Picked something in the Cashier Location!");
    }
}
