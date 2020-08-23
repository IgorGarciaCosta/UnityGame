using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canhaoAtira : MonoBehaviour
{
    [SerializeField]//pra variável poder se editável dentro do Unity
    GameObject balaCanhao;
    [SerializeField]
    Transform disparador;
    public float tempoEntreTiros = 3f;//atira a cada 3 segundos
    private float cronometro =0;



    void Atirar(){//instacia uma balad de cahão na posição
        cronometro = 0;//a cada tiro o cronometro zera
        Instantiate(balaCanhao, disparador.position, disparador.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        cronometro += Time.deltaTime;//incrementa 1 segundo ao tempo no cronometro

        if(cronometro >=3){//passados 3 segundos, atirar
            Atirar();
        }
    }
}
