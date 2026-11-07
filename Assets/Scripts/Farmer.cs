using UnityEngine;

public class Farmer : MonoBehaviour
{
    public GameObject speechBubble;
    public GameObject shopUI;

    private bool nearby = false;
    private bool shopOpen = false;

    void Update()
    {
        if (nearby && Input.GetKeyDown(KeyCode.E))
        {
            if (shopOpen)
            {
                CloseShop();
            }
            else
            {
                OpenShop();
            }
        }
    }

    void OpenShop()
    {
        shopUI.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        shopOpen = true;
    }

    void CloseShop()
    {
        shopUI.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        shopOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        nearby = true;
        if (other.CompareTag("Player"))
        {
            speechBubble.SetActive(true);
            nearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            nearby = false;
            speechBubble.SetActive(false);
            CloseShop();

        }
    }
}
