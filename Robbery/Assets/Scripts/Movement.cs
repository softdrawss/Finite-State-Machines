using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public NavMeshAgent agent;

    public void Seek(Transform target)
    {
        agent.destination = target.position;
    }
}
