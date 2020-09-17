using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
        
    public float tempoUmSegundo = 1f;
    public float contadorDeTempo =100;

    jogador jogador;
    [SerializeField]
    Text vidaTXT, pontosTXT, mensagemTXT, tempoTXT;
    // Start is called before the first frame update
    void Start()
    {
        //obj jogador recebe script do Jogador
        jogador = GameObject.FindGameObjectWithTag("Player").GetComponent<jogador>();
        mensagemTXT.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        contadorDeTempo -= Time.deltaTime;//decrementa 1 segundo ao tempo no contador
        
        tempoTXT.text = "Tempo: "+(int)contadorDeTempo;
        vidaTXT.text = "Vida: " + jogador.vidaAtual.ToString();
        pontosTXT.text = "X: " + jogador.pontuacao.ToString();

        if (jogador.vidaAtual <= 0)
        {
            mensagemTXT.text = "Perdeste!";
            Time.timeScale = 0;
        }

        if (jogador.pontuacao == 14)
        {
            mensagemTXT.text = "Ganhaste!";
            Time.timeScale = 0;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
