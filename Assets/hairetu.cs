using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = { 83, 99, 52, 93, 15 };

        int sum = 0;
        {
            for (int i = 0; i< points.Length; i++)
            {
              sum += points[i];
            }
            int average = sum / points.Length;
            Debug.Log(average);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
