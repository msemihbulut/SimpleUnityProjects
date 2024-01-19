using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxiss : MonoBehaviour
{

    private float deger1, deger2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deger1 = Input.GetAxis("Horizontal");
        deger2 = Input.GetAxis("Vertical");

        if(deger1 > 0)
        {
            print("D veya sağ ok tuşu");
        }

        else if(deger1 < 0)
        {
            print("A veya sol ok tuşu");
        }
        else
        {
            print("Tusa basmadınız");
        }

        if(deger2 > 0)
        {
            print("w veya yukari ok tuşu");
        }

        else if(deger2 < 0)
        {
            print("s veya asagi ok tuşu");
        }
        else
        {
            print("Tusa basmadınız");
        }


    }
}
