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

    //���� �ʱ�ȭ �޼���
    public void InitializeShop()
    {
        currentItem = new Item { Name = "��", Price = 100 };
        shopView.UpdateUI(currentItem);

    }
    
    /*player�� �������� ����� shopView�� player�����ϰ�,���� shopView���� ��������. 
     * => �������̽� Ư���� �ڽ� Ŭ������ �������� �κ��� ���ܾ��ϱ� ������ ���� �Ұ�.
     * 
     * �׷��ٸ� BuyItem�� �׳� ShopView�� �����ϸ�? currentItem�� ������ ���� ����
     * �����Ѵٸ� view�� model���� ���ռ��� ������Ű�� ��.
     *
     * ���� player�� static������ �����Ѵ�. ������ �ٸ� View������ ���� �̿��� ���̱� ������,
     * �ڵ� ���� ���������� ���ϴ�
     * */
    
    //������ ���� �޼���
    public void BuyItem()
    {
        //�÷��̾� ��ȭ���� Ȯ���Ѵ�
        if (Player.playerCurrency >= currentItem.Price)
        {
            Player.playerCurrency -= currentItem.Price; //�÷��̾��� ��ȭ�� ������Ʈ

            AddItemToInventory(currentItem); //�÷��̾��� �κ��丮�� �������߰�

            Debug.Log("���� ���� ");
            Debug.Log(Player.playerCurrency + "�Դϴ�");
        }
        else
        {
            Debug.Log("���� �����մϴ�");
        }

    }

  

    private void AddItemToInventory(Item item)
    {
        Player.playerInventory.Add(item);
    }
    
}
