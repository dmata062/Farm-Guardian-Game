using UnityEngine;

public class CropPlacer : MonoBehaviour
{
    public GameObject cropPrefab;
    public PlayerInventory inventory;

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            PlaceCrop();
        }
    }

    void PlaceCrop()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                Vector3 spawnPosition = hit.point;

                
                spawnPosition.x = Mathf.Round(spawnPosition.x);
                spawnPosition.z = Mathf.Round(spawnPosition.z);
                if(inventory.corn >= 1)
                {
                    Instantiate(cropPrefab, spawnPosition, transform.rotation);
                    inventory.corn--;
                }
                
            }
        }
    }
}