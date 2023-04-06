using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboFlotante : MonoBehaviour
{

    public float speed_rotation = 240.0f;
    public float wave_Amplitude = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//rotate in the Y axis with
        transform.Rotate(0, speed_rotation*Time.deltaTime , 0);
    }
}
