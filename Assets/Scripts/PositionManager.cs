using UnityEngine;

public class PositionManager : MonoBehaviour
{
    public GameObject fence;
    public GameObject tower;
    public float spawnDistance = 3f;
    public PlayerInventory inventory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            SpawnFence();
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            SpawnTower();
        }
    }

    void SpawnFence()
    {
        Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;
        if(inventory.fences >= 1)
        {
            Instantiate(fence, spawnPosition, transform.rotation);
            inventory.fences--;
        }
    }

    void SpawnTower()
    {
        Vector3 spawnPosition = transform.position + transform.forward * spawnDistance;
        if(inventory.towers >= 1)
        {
            Instantiate(tower, spawnPosition, transform.rotation);
            inventory.towers--;
        }
    }
}
