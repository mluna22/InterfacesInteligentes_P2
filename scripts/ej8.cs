using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8 : MonoBehaviour
{
    GameObject[] spheres;
    float[] distances;

    // Start is called before the first frame update
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("yellows");
        distances = new float[spheres.Length];
    }

    // Update is called once per frame
    void Update()
    {
        float maxDistance = 0;
        int maxDistanceIndex = 0;
        float minDistance = Mathf.Infinity;
        int minDistanceIndex = 0;
        for (int i = 0; i < spheres.Length; ++i) {
            distances[i] = Vector3.Distance(gameObject.transform.position, spheres[i].transform.position);
            if (maxDistance < distances[i]) {
                maxDistance = distances[i];
                maxDistanceIndex = i;
            }
            if (minDistance > distances[i]) {
                minDistance = distances[i];
                minDistanceIndex = i;
            }
        }
        spheres[minDistanceIndex].transform.position += new Vector3(0,0.01f,0);
        if (Input.GetKeyDown(KeyCode.Space)) {
            spheres[maxDistanceIndex].GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1);
        }
    }
}
