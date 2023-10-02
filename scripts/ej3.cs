using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3 : MonoBehaviour
{
    public Vector3 myVector1;
    public Vector3 myVector2;
    public float magnitud_1;
    public float magnitud_2;
    public float angulo;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        magnitud_1 = myVector1.magnitude;
        Debug.Log("Magnitud 1: " + magnitud_1);
        magnitud_2 = myVector2.magnitude;
        Debug.Log("Magnitud 2: " + magnitud_2);
        angulo = Vector3.Angle(myVector1, myVector2);
        Debug.Log("Ángulo: " + angulo);
        distancia = Vector3.Distance(myVector1, myVector2);
        Debug.Log("Distancia: " + distancia);
        if (myVector1.y == myVector2.y) Debug.Log("Ambos vectores tienen la misma altura");
        else Debug.Log("El vector " + (myVector1.y > myVector2.y ? "1" : "2") + " tiene mayor altura");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
