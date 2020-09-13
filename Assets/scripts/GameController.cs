using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    jogador jogador;
    [SerializeField]
    Text vidaTXT, pontosTXT, mensagemTXT;
    // Start is called before the first frame update
    void Start()
    {
        //obj jogador recebe script do Jogador
        jogador  = GameObject.FindGameObjectWithTag("Player").GetComponent<jogador>();
        mensagemTXT.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaTXT.text = "Vida: " + jogador.vidaAtual.ToString();
        pontosTXT.text = "X: " + jogador.pontuacao.ToString();

        if(jogador.vidaAtual<=0){
            mensagemTXT.text = "Perdeste!";
            Time.timeScale = 0;
        }

        if(jogador.pontuacao==14){
            mensagemTXT.text = "Ganhaste!";
            Time.timeScale = 0;
        }
    }
}
