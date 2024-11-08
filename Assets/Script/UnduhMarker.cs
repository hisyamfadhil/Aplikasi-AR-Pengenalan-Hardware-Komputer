using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Marker : MonoBehaviour{
    public string urlToOpen = "https://drive.google.com/drive/folders/1cVMJiGIl7je9gSQ0Q5uwHv4Qf3vrt5aX?hl=id";
    public void OpenURL(){
        Application.OpenURL(urlToOpen);
    }
    public void Back(){
        SceneManager.LoadScene("MainMenu");
    }
}