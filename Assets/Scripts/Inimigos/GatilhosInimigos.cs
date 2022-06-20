using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatilhosInimigos : MonoBehaviour
{
    [Header("Gatilhos de inimigo para inimigo")]
    public bool InimigosColidindo;

    void OnTriggerEnter(Collider colisao) {
        if (colisao.gameObject.tag == "Inimigo") {
            InimigosColidindo = true;
        }
    }
}
