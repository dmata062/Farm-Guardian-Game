using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI inventoryText;

    public PlayerInventory inventory;

    void Update()
    {
        inventoryText.text =
            "Corn: " + inventory.corn +
            "\n\n[Left Click] Rocks: " + inventory.rocks +
            "\n[F] Fences: " + inventory.fences +
            "\n[G] Towers: " + inventory.towers;
    }
}
