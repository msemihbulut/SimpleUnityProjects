using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindWithTag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectsWithTag("ozel")[1].SetActive(false);
        GameObject.FindGameObjectsWithTag("ozel")[0].GetComponent<Light>().intensity = 0f;
        GameObject.Find("Kapsul").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
