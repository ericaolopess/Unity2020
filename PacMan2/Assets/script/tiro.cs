using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class tiro : MonoBehaviour
{
    float bala;

    // Start is called before the first frame update
    void Start()
    {
        bala = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bala, 0, 0);

        if(transform.position.x > 50 || transform.position.x < -50 
             || transform.position.z > 50 || transform.position.z < -50)
        {
            Destroy(gameObject);
        }
        
    }

    void OnCollisionEnter(Collision Collider)
    {
        Destroy(gameObject);
    }

}
