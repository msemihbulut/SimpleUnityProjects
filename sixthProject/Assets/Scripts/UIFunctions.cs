using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFunctions : MonoBehaviour
{
    public float volumeLevel;
    public float brightnessLevel;
    public string graphicQuality;
    public string currentUsername;
    
    public void GameExit()
    {
        print("Oyundan cikildi...");
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void InputUsername(string Username)
    {
        print("Username: " + Username);
        currentUsername = Username;
    }

    public void GraphicQuality(int choose)
    {
        if(choose == 0)
        {
            print("High");
            graphicQuality = "High";
        }

        else if(choose == 1)
        {
            print("Medium");
            graphicQuality = "Medium";
        }
        
        else
        {
            print("Low");
            graphicQuality = "Low";
        }
    }

    public void VolumeLevel(float deger)
    {
        print(deger);
        volumeLevel = deger;
    }

    public void BrightnessLevel(float deger)
    {
        print(deger);
        brightnessLevel = deger;
    }

    public void VsyncOnOff(bool VsyncOn)
    {
        if(VsyncOn)
        {
            print("Vsync On");
        }

        else
        {
            print("Vsync Off");
        }
    }

}
