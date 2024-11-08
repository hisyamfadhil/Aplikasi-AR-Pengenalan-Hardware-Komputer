using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Mulai(){
        SceneManager.LoadScene("Mulai");
    }    
    
    public void Tentang(){
        SceneManager.LoadScene("Tentang");
    }

    public void Bantuan(){
        SceneManager.LoadScene("Bantuan");
    }

    public void UnduhMarker(){
        SceneManager.LoadScene("UnduhMarker");
    }

    public void Keluar(){
        Application.Quit();
        Debug.Log("Game Telah Keluar");
    }
}