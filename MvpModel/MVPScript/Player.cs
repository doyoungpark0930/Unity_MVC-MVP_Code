using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    static public int playerCurrency { get; set; } = 1000;
    static public List<Item> playerInventory = new List<Item>();
}
