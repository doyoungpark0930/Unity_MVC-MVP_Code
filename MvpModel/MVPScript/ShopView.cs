using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopView : MonoBehaviour, IShopView
{
    public Text itemText;
    public Text priceText;
    public Button buyButton;

    private ShopPresenter shopPresenter;

    private void Awake()
    {
        shopPresenter = new ShopPresenter(this);
    }

    public void UpdateUI(Item item)
    {
        itemText.text = item.Name;
        priceText.text = item.Price.ToString();
    }

    public void OnInitializeClick()
    {
        shopPresenter.InitializeShop();
    }
    
    
    public void OnBuyButtonClick()
    {
        shopPresenter.BuyItem();
    }
    

   
}
