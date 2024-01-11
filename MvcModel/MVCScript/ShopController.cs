using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controller
public class ShopController : MonoBehaviour
{
    public Player player;
    public List<ShopView> shopView = new List<ShopView>();
    public List<Item> currentItem = new List<Item>(new Item[2]); //���� �ΰ��ϱ� ���� Item���� 2��
   
    Item tempItem;
  
    //���� �ʱ�ȭ �޼���
    public void InitializeShop() //ù��° ���� �ʱ�ȭ �޼���
    {
        tempItem = new Item { Name = "��", Price = 100 }; //ù��° ������ ��Ÿ�� ��
        currentItem[0] = tempItem;

        shopView[0].UpdateUI(tempItem);
    }
    public void InitializeShop2() //�ι�° ���� �ʱ�ȭ �޼���
    {
        tempItem = new Item { Name = "Ȱ", Price = 200 }; //�ι�° ������ ��Ÿ�� ��
        currentItem[1] = tempItem;

        shopView[1].UpdateUI(tempItem);
    }
    
    //������ ���� �޼���
    public void BuyItem(int x) //ù��° �������� 0, �ι�° �������� 1�� ���ڷ� �ִ´�
    {
        //�÷��̾� ��ȭ���� Ȯ���Ѵ�
        if(player.playerCurrency >= currentItem[x].Price)
        {
            player.playerCurrency -= currentItem[x].Price; //�÷��̾��� ��ȭ�� ������Ʈ

            AddItemToInventory(currentItem[x]); //�÷��̾��� �κ��丮�� �������߰�

            Debug.Log("���� ���� ");
            Debug.Log(player.playerCurrency+"�Դϴ�");
        }
        else
        {
            Debug.Log("���� �����մϴ�");
        }

    }


    private void AddItemToInventory(Item item)
    {
        player.playerInventory.Add(item);
    }
}
