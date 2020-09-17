using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canhaoAtira : MonoBehaviour
{
    [SerializeField]//pra variável poder se editável dentro do Unity
    GameObject balaCanhao;
    [SerializeField]
    Transform disparador;
    public float tempoEntreTiros = 0.8f;//atira a cada 1 segundo
    private float cronometro =0;

    jogador jogador;

    void Atirar(){//instacia uma balad de cahão na posição
        //dá acesso às variáveis do obj jogador
        jogador = GameObject.FindGameObjectWithTag("Player").GetComponent<jogador>();
        cronometro = 0;//a cada tiro o cronometro zera
        Instantiate(balaCanhao, disparador.position, disparador.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        cronometro += Time.deltaTime;//incrementa 1 segundo ao tempo no cronometro

        if(cronometro >=tempoEntreTiros){
            Atirar();
        }
        if(jogador.pontuacao >= 5){
            tempoEntreTiros = 0.3f;
        }
        if(jogador.pontuacao >= 10){
            tempoEntreTiros = 0.1f;
        }
    }
}
