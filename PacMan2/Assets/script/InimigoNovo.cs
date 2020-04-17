
using System.Security.Cryptography;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.AI;

public class InimigoNovo : MonoBehaviour
{

    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination
            (GameObject.FindGameObjectWithTag("Player").transform.position);

    }
}

