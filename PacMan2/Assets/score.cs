using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int pontos;
    public GameObject coletavel;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
    }

    public void addPonto()
    {
        pontos++;
        GetComponent<Text>().text = "Score: " + pontos;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
