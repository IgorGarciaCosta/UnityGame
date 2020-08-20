using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apontarParaInimigo : MonoBehaviour
{
    [SerializeField]
    Transform alvo;
    Vector3 v3_alvo;//vai pegar o posicionamento do personagem
    

    // Update is called once per frame
    //obs: Update trabalha cada frame, mas o fixedUpdate trabalha melhor com física
    void FixedUpdate()
    {
        //instância de Vector3
        v3_alvo = new Vector3(alvo.position.x,alvo.position.y,alvo.position.z);
        transform.LookAt(v3_alvo);//manda o canhão olhar na posição do personagem
    }
}
