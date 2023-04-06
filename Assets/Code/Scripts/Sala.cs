using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sala : MonoBehaviour
{
    public Vector3 entrada;
    public float ancho=1;
    public float largo=1;
    public float alto=1;
    //constructor
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(transform.localScale.x*ancho, transform.localScale.y*alto, transform.localScale.z*largo);
    }

    private void Update()
    {
       
        }
}