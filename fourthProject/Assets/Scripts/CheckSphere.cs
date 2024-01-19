using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.CheckSphere(transform.position, 1f))
        {
            print("çarpma gerçekleşti");
        }

        
    }
}
