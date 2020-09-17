using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mudarCena : MonoBehaviour
{

    public string nomeDaCena;
    
    public void ChangeS(){
        SceneManager.LoadScene(nomeDaCena);
    }

    public void SairDoJogo(){
        Application.Quit();
    }
}
