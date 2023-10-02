using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6 : MonoBehaviour
{
    GameObject cube;
    GameObject cylinder;
    
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        cylinder = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.position = gameObject.transform.position + new Vector3(5,0,0);
        cylinder.transform.position = gameObject.transform.position + new Vector3(-5,0,0);
    }
}
