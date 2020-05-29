using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    public GameObject score;


    void Start()
    {

    }

    void OnCollisionEnter(Collision Collide)
    {
        
        if (Collide.gameObject.tag == "Player")
        {
            score.GetComponent<score>().addPonto();
            Destroy(gameObject);
        }
    }

}
