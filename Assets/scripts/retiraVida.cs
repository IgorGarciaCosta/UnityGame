using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retiraVida : MonoBehaviour
{
    jogador jogador;
    int PoderDoTiro = 20;

        void Start()
    {
        //recebe o script de jogador
        jogador = GameObject.FindGameObjectWithTag("Player").GetComponent<jogador> ();
    }

    void OnTriggerEnter(Collider outro){
        if(outro.tag == "Player"){//se colidiu com o jogador
            jogador.vidaAtual -= PoderDoTiro;
            Destroy(gameObject);//destroi bala ao tocar no personagem
        }
    }

    void Update()
    {
        
    }
}
