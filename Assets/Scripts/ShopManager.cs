using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public PlayerInventory inventory;

    public void BuyRocks()
    {
        if (inventory.corn >= 2)
        {
            inventory.corn -= 2;
            inventory.rocks += 1;
        }
    }

    public void BuyFence()
    {
        if (inventory.corn >= 5)
        {
            inventory.corn -= 5;
            inventory.fences += 1;
        }
    }

    public void BuyTower()
    {
        if (inventory.corn >= 20)
        {
            inventory.corn -= 20;
            inventory.towers += 1;
        }
    }
}  
