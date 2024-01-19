using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime = 1/fps
    }

    private void FixedUpdate()
    {
        timer += 1 * Time.fixedDeltaTime;
        print(timer);
    }
}
