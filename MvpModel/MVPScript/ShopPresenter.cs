using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//presenter
public class ShopPresenter
{
    
    private IShopView shopView;
    private Item currentItem;


    public ShopPresenter(IShopView view)
    {
        shopView = view;
    }

    //상점 초기화 메서드
    public void InitializeShop()
    {
        currentItem = new Item { Name = "검", Price = 100 };
        shopView.UpdateUI(currentItem);

    }
    
    /*player를 가져오는 방법은 shopView에 player선언하고,위의 shopView에서 가져오기. 
     * => 인터페이스 특성상 자식 클래스의 디테일한 부분을 숨겨야하기 때문에 접근 불가.
     * 
     * 그렇다면 BuyItem을 그냥 ShopView에 정의하면? currentItem에 접근할 수가 없음
     * 접근한다면 view와 model간의 결합성을 증가시키게 됨.
     *
     * 따라서 player를 static변수로 선언한다. 어차피 다른 View에서도 많이 이용할 것이기 때문에,
     * 코드 관리 차원에서도 편하다
     * */
    
    //아이템 구입 메서드
    public void BuyItem()
    {
        //플레이어 통화량을 확인한다
        if (Player.playerCurrency >= currentItem.Price)
        {
            Player.playerCurrency -= currentItem.Price; //플레이어의 통화량 업데이트

            AddItemToInventory(currentItem); //플레이어의 인벤토리에 아이템추가

            Debug.Log("남은 돈은 ");
            Debug.Log(Player.playerCurrency + "입니다");
        }
        else
        {
            Debug.Log("돈이 부족합니다");
        }

    }

  

    private void AddItemToInventory(Item item)
    {
        Player.playerInventory.Add(item);
    }
    
}
