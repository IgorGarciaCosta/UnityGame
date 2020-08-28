using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTiro : MonoBehaviour
{
    [SerializeField]
    float min_ForcaTiro = 5f, max_forcaTiro = 18f;

    Rigidbody BalaCanhao;
    // Start is called before the first frame update
    void Start()
    {
        BalaCanhao = GetComponent<Rigidbody>();
        BalaCanhao.velocity = transform.forward*(Random.Range(min_ForcaTiro, max_forcaTiro));
    }

   
}
