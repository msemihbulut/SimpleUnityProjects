using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proje : MonoBehaviour
{
    public int baslangic = 13;
    public int bitis = 56;

    static void bolenleriBul(int baslangic, int bitis)
    {
        
        string tumSayilar = "";
        string ikiyeBolunenler = "";
        string uceBolunenler = "";
        string dorteBolunenler = "";
        string beseBolunenler = "";

        for (int i = baslangic; i <= bitis; i++)
        {
            tumSayilar += i + " - ";

            if (i % 2 == 0)
                ikiyeBolunenler += i + " - ";

            if (i % 3 == 0)
                uceBolunenler += i + " - ";

            if (i % 4 == 0)
                dorteBolunenler += i + " - ";

            if (i % 5 == 0)
                beseBolunenler += i + " - ";
        }

        print("Tüm Sayılar: " + tumSayilar);
        print("İkiye Bölünenler: " + ikiyeBolunenler);
        print("Üçe Bölünenler: " + uceBolunenler);
        print("Dörde Bölünenler: " + dorteBolunenler);
        print("Beşe Bölünenler: " + beseBolunenler);
    }


    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(baslangic, bitis);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
