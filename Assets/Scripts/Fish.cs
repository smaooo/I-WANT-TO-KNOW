using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    void Start()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
