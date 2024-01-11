using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controller
public class ShopController : MonoBehaviour
{
    public Player player;
    public List<ShopView> shopView = new List<ShopView>();
    public List<Item> currentItem = new List<Item>(new Item[2]); //상점 두개니까 받을 Item변수 2개
   
    Item tempItem;
  
    //상점 초기화 메서드
    public void InitializeShop() //첫번째 상점 초기화 메서드
    {
        tempItem = new Item { Name = "검", Price = 100 }; //첫번째 상점에 나타낼 값
        currentItem[0] = tempItem;

        shopView[0].UpdateUI(tempItem);
    }
    public void InitializeShop2() //두번째 상점 초기화 메서드
    {
        tempItem = new Item { Name = "활", Price = 200 }; //두번째 상점에 나타낼 값
        currentItem[1] = tempItem;

        shopView[1].UpdateUI(tempItem);
    }
    
    //아이템 구입 메서드
    public void BuyItem(int x) //첫번째 상점에는 0, 두번째 상점에는 1을 인자로 넣는다
    {
        //플레이어 통화량을 확인한다
        if(player.playerCurrency >= currentItem[x].Price)
        {
            player.playerCurrency -= currentItem[x].Price; //플레이어의 통화량 업데이트

            AddItemToInventory(currentItem[x]); //플레이어의 인벤토리에 아이템추가

            Debug.Log("남은 돈은 ");
            Debug.Log(player.playerCurrency+"입니다");
        }
        else
        {
            Debug.Log("돈이 부족합니다");
        }

    }


    private void AddItemToInventory(Item item)
    {
        player.playerInventory.Add(item);
    }
}
