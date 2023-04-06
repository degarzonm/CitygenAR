using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public GameObject roadPrefab;
    public GameObject salaPrefab;
    public float roadLengthSegment = 1.0f;
    public float roadWidthSegment = 1.0f;
    public float angleNoiseRoad = 15.0f;
    public int maxSegments = 10;
   

    private Vector3 previousPoint;

    void Start()
    {
        previousPoint = transform.position;
        for (int i = 0; i < maxSegments; i++)
        {
            // Calculate next point
            Vector3 nextPoint = previousPoint + Quaternion.Euler(0, Random.Range(-angleNoiseRoad, angleNoiseRoad), 0) * transform.forward * roadLengthSegment;

            // Instantiate road prefab
            GameObject road = Instantiate(roadPrefab, transform);

            // Set road length and width
            road.GetComponent<Road>().largo =roadLengthSegment;
            road.GetComponent<Road>().ancho=roadWidthSegment ;
            // instantiate sala prefab along the road taking into account the road width but not the scale
            //GameObject sala = Instantiate(salaPrefab,  road.transform.position + new Vector3(0, 0, roadWidthSegment / 2), Quaternion.identity);
            
            // Position road plus a random y
            road.transform.position = previousPoint+new Vector3(0, Random.Range(-0.02f, 0.02f), 0);

            // Rotate road to face next point
            road.transform.LookAt(nextPoint);

            // Update previous point
            previousPoint = nextPoint;
        }
    }
}

