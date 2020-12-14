using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasers : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col) {
        Destroy(col.gameObject); 
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
        
    }
}
