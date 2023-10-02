using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej7 : MonoBehaviour
{
    Material cylinder_material;
    Material cube_material;
    // Start is called before the first frame update
    void Start()
    {
        cylinder_material = GameObject.Find("Cylinder").GetComponent<Renderer>().material;
        cube_material = GameObject.Find("Cube").GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            cylinder_material.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            cube_material.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1);
        }
    }
}
