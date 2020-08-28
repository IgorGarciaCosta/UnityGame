using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroiObjeto : MonoBehaviour
{
    [SerializeField]
    float tempoVida = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //destroi o objeto ao qual script está associado
        Destroy(gameObject, tempoVida);
    }

    
}
