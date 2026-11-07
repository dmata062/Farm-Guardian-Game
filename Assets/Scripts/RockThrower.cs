using UnityEngine;
using UnityEngine.EventSystems;

public class RockThrower : MonoBehaviour
{
    public GameObject rockPrefab;

    public Transform throwPoint;

    public float throwForce = 20f;

    public PlayerInventory inventory;

    void Update()
    {

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            ThrowRock();
        }
    }

    void ThrowRock()
    {
        if (inventory.rocks <= 0)
        {
            return;
        }

        GameObject rock = Instantiate(rockPrefab,throwPoint.position,Quaternion.identity);

        Rigidbody rb = rock.GetComponent<Rigidbody>();

       
        rb.AddForce(Camera.main.transform.forward * throwForce,ForceMode.Impulse);

        inventory.rocks--;

    }
}