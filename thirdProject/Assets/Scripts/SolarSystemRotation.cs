using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemRotation : MonoBehaviour
{
    public Vector3 rotasyon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotasyon);
    }
}
