using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float largo;
    public float ancho;
    //constructor
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(ancho, transform.localScale.y, largo);
    }

    private void Update()
    {
        // Scale road to match length
        }
}


