using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    



    public GameObject panel;
    
    public void CikisButonu()
    {
        print("Oyundan çıkıldı...");
        Application.Quit();
    }
    
    public void YeniOyun()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene("YeniOyun");
    }

    public void IlkSahne()
    {
        SceneManager.LoadScene(0);
    }

    public void On_Value_Changed(float deger)
    {
        print(deger);
    }

    public void ToggleEnabled(bool TiklandiMi)
    {
        if(TiklandiMi)
        {
            print("ses acik");
        }

        else
        {
            print("ses kapali");
        }
    }

    public void OnEndEditText(string MetinselDeger)
    {
        print("metin: " + MetinselDeger);
    }

    public void DropDownValue(int sayi)
    {
        if(sayi == 0)
        {
            print("araba alimi");
        }

        else if(sayi == 1)
        {
            print("ev alimi");
        }
        
        else
        {
            print("arsa alimi");
        }
    }

    public void OyunaGeriDon()
    {
        panel.gameObject.SetActive(false);


    }

}
