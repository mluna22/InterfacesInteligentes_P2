using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.Find("Cube");
        GameObject cylinder = GameObject.Find("Cylinder");
        Debug.Log("Distancia al cubo: " + 
            Vector3.Distance(gameObject.transform.position, cube.transform.position));
        Debug.Log("Distancia al cilindro: " + 
            Vector3.Distance(gameObject.transform.position, cylinder.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
