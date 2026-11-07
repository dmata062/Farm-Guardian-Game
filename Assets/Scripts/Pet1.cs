using UnityEngine;
using UnityEngine.AI;

public class PetAI : MonoBehaviour
{
    private NavMeshAgent agent;

    private GameObject targetEnemy;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        FindClosestEnemy();

       
        if (targetEnemy != null)
        {
            agent.SetDestination(targetEnemy.transform.position);
        }
    }

    void FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy1");

        targetEnemy = null;

        float closestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(
                transform.position,
                enemy.transform.position
            );

            if (distance < closestDistance)
            {
                closestDistance = distance;
                targetEnemy = enemy;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy1"))
        {
            Destroy(other.gameObject);

            targetEnemy = null;
        }
    }
}