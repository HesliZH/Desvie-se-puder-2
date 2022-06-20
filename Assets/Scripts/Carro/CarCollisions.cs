using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisions : MonoBehaviour
{
    public bool Bateu = false;

    private void Update()
    {
        Debug.Log("Funcionando");
    }

    private void OnTriggerEnter(Collider colisao) {
        if (colisao.gameObject.tag == "Inimigo") {
            Debug.Log("Bateu em: " + colisao.gameObject.name);
            Bateu = true;
        }
    }
}
