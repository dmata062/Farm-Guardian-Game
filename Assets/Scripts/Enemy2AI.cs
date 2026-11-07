using UnityEngine;
using UnityEngine.AI;
using TMPro;
using System.Collections;

public class Enemy2AI : MonoBehaviour
{
    private NavMeshAgent agent;

    private Transform player;

    public GameObject losetext;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        agent.SetDestination(player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Time.timeScale = 0f;
            losetext.SetActive(true);
        }
    }
}