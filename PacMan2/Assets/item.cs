using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    void OnCollisionEnter(Collision Collide)
    {
        
        if (Collide.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
