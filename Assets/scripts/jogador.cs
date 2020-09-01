using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public int vidaInicial = 100;
    public int vidaAtual;
    public int pontuacao;


    // Start is called before the first frame update
    void Start()
    {
        vidaAtual = vidaInicial;
        pontuacao = 0;
    }

    void OnTriggerEnter(Collider outroColisor){
        if(outroColisor.tag =="Moeda"){
            Destroy(outroColisor.gameObject);
            pontuacao ++;
        }
    }

    void Update(){
        print(vidaAtual);
    }


}
