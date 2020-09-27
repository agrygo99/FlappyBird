using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{

    public void NewGame(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Reset(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit(){
        Application.Quit();
    }

}
