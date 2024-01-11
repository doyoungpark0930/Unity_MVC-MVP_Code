using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerCurrency { get; set; } = 1000;
    public List<Item> playerInventory = new List<Item>();

}
