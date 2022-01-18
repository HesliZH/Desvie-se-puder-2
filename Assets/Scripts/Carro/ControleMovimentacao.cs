using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMovimentacao : MonoBehaviour
{
    private CharacterController Controlador;
    private Vector3 Direcao;

    public float Velocidade;

    private int PistaRodada = 1; /* Caminhos disponíveis 0 = esquerda , 1 = meio , 2 - direita*/
    public int TamanhoPista = 4;
    void Start()
    {
        Controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        Direcao.z = Velocidade;


        /*Analisa o input do jogador e define a pista que será usada*/
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            PistaRodada++;

            if (PistaRodada == 3){
                PistaRodada = 2;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            PistaRodada--;

            if (PistaRodada == -1){
                PistaRodada = 0;
            }
        }

        /*Fórmula para calculo da posição entre pistas*/

        Vector3 Alvo = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (PistaRodada == 0){
            Alvo += Vector3.left * TamanhoPista;
        }else if (PistaRodada == 2){
            Alvo += Vector3.right * TamanhoPista;
        }

        transform.position = Alvo;
    }

    private void FixedUpdate(){
        Controlador.Move(Direcao * Time.fixedDeltaTime);
    }
}
