using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
  // Start is called before the first frame update
  int arraySize = 10;
  public int range = 25;
  int[] cubeArray;
  void Start()
  {
    cubeArray = new int[arraySize];
    for (int i = 0; i < arraySize; ++i) {
      cubeArray[i] = Random.Range(0, range);
      Debug.Log(cubeArray[i]);
    }
  }

  // Update is called once per frame
  void Update()
  {
    int pos = Random.Range(0, arraySize - 1);
    cubeArray[pos] = Random.Range(0, range);
    if (cubeArray[pos] > 15) Debug.Log(cubeArray[pos]);
  }
}
