
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


    void OnCollisionEnter(Collision Collide)
    {
    
        if (Collide.gameObject.tag == "tiro")
        {
            Destroy(gameObject);
        }
    }
}

