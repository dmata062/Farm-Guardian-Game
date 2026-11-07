using UnityEngine;
using UnityEngine.AI;

public class Enemy1AI : MonoBehaviour
{
    private NavMeshAgent agent;

    private GameObject targetCrop;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {

        FindClosestCrop();
        if (targetCrop != null)
        {   
            FindClosestCrop();
            agent.SetDestination(targetCrop.transform.position);
        }
    }

    void FindClosestCrop()
    {
        GameObject[] crops = GameObject.FindGameObjectsWithTag("Crop");

        targetCrop=null;

        float closestDistance = Mathf.Infinity;

        foreach (GameObject crop in crops)
        {
            float distance = Vector3.Distance(
                transform.position,
                crop.transform.position
            );

            if (distance < closestDistance)
            {
                closestDistance = distance;
                targetCrop = crop;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Crop"))
        {
            Destroy(other.gameObject);

            targetCrop = null;
        }
    }
}