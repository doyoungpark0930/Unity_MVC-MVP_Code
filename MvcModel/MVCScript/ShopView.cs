using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//View
public class ShopView : MonoBehaviour
{
    public Text itemText;
    public Text priceText;
    public Button buyButton;

    public void UpdateUI(Item item)
    {
        itemText.text = item.Name;
        priceText.text = item.Price.ToString();
    }
}
