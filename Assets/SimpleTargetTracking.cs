using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class SimpleTargetTracking : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> goals;
    private NavMeshAgent agent;
    int i;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        i = 0;
        agent.SetDestination(goals[i].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            agent.SetDestination(goals[i].position);
            i++;
            if (i == goals.Count) i = 0;
        }
    }
}
