using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giraItem : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //rotaciona o eixo Y de 60 em 60 graus
        transform.Rotate(new Vector3(0, 60,0)*Time.deltaTime);//Time.deltaTime faz o giro durar 1 segundo
        
    }
}
