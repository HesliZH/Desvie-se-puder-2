using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInimigos : MonoBehaviour
{
    public GameObject[] Inimigos;
    public GameObject Spawner;
    public GameObject Player;
    private int i;
    public Transform PosicaoPlayer;
    public float NumeroPistas = 3;
    public float zSpawn = 0;
    public int QuantidadeEspacos = 5;
    private int Esquerda = -3;
    private int Direita = 3;
    private int Meio = 0;
    private int LadoSelecionado;
    private int UltimoLado;

    void Start(){
        for(int i = 0; i <= Inimigos.Length - 1; i++){
            Inimigos[i].transform.localScale = new Vector3(50, 50, 50);
            Inimigos[i].tag = "Inimigo";
        }
    }
    void Update(){
        if(PosicaoPlayer.position.z > zSpawn - (NumeroPistas * Inimigos.Length)){
            CarregaInimigos();
        }
        
    }

    public void CarregaInimigos(){
        LadoSelecionado = Random.Range(1, 5);
        
        switch(LadoSelecionado){
            case 1: 
                Instantiate(Inimigos[Random.Range(0, Inimigos.Length)], new Vector3(Esquerda, 0.66f, Player.transform.position.z + 50), new Quaternion(0, 180, 0, 1));
            break;
            case 2: 
                Instantiate(Inimigos[Random.Range(0, Inimigos.Length)], new Vector3(Meio, 0.66f, Player.transform.position.z + 50), new Quaternion(0, 180, 0, 1));
            break;
            case 3: 
                Instantiate(Inimigos[Random.Range(0, Inimigos.Length)], new Vector3(Direita, 0.66f, Player.transform.position.z + 50), new Quaternion(0, 180, 0, 1));
            break;
        }

        zSpawn += QuantidadeEspacos;
        UltimoLado = LadoSelecionado;
    }
}
