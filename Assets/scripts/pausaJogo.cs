using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausaJogo : MonoBehaviour
{
    public GameObject botaoDePause;

public void pausa(){

    //1:jogo rodando normalmente, 0:jogo parado
    if(Time.timeScale==1){
        Time.timeScale = 0;
    }
    else{
        Time.timeScale =1;
    }
}

}
