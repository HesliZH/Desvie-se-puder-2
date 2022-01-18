using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlePontos : MonoBehaviour
{
    public GameObject Jogador;
    private float Pontos;
    public Text MarcadorPontos;
    void Update()
    {
        if (Jogador.GetComponent<CharacterController>().velocity != new Vector3(0,0,0)){
            Pontos++;
        }

        MarcadorPontos.text = Pontos.ToString();
    }
}
