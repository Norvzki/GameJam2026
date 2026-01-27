using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace game.stageone
{
    public abstract class location : MonoBehaviour
    {
        public static int Carried = 0;
        protected int foodcount, watercount, medkitcount;

        protected bool toolbox, radio, sundang, sungka, cards;

        [Header("Supplies")]
        public Button[] food;
        public Button[] water;
        public Button[] medkit;

        [Header("Special Items")]
        public Button toolbox_button;
        public Button radio_button;
        public Button sundang_button;
        public Button sungka_buttons;
        public Button cards_buttons;
        public virtual void Start()
        {
            AddListeners(food);
            AddListeners(water);
            AddListeners(medkit);

            AddSingle(toolbox_button);
            AddSingle(radio_button);
            AddSingle(sundang_button);
            AddSingle(sungka_buttons);
            AddSingle(cards_buttons);
        }
        protected void clicked(Button item)
        {
            if (Carried <= 5)
            {
                Carried++;
                switch (item.tag)
                {
                    case "food":
                        foodcount++;
                        break;
                    case "water":
                        watercount++;
                        break;
                    case "medkit":
                        medkitcount++;
                        break;
                    case "toolbox_button":
                        toolbox = true;
                        break;
                    case "radio_button":
                        radio = true;
                        break;
                    case "sundang_button":
                        sundang = true;
                        break;
                    case "sungka_buttons":
                        sungka = true;
                        break;
                    case "cards_buttons":
                        cards = true;
                        break;
                }
                item.interactable = false;
                item.gameObject.SetActive(false);
                OnItemPicked(item);
            } else
            {
                Debug.Log("Carrying is over the limit! Checkout your items first");
            }
        }
        protected abstract void OnItemPicked(Button item);
        protected void AddListeners(Button[] buttons)
        {
            foreach (Button b in buttons)
            {
                b.onClick.AddListener(() => clicked(b));
            }
        }
        protected void AddSingle(Button button)
        {
            if (button != null)
                button.onClick.AddListener(() => clicked(button));
        }
    }
}