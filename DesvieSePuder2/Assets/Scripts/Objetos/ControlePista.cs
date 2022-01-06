using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePista : MonoBehaviour
{
    public GameObject[] Pistas;
    public float zSpawn = 0;
    public float tamanhoPista = 20;
    public float NumeroPistas = 10;
    public GameObject ObjetoPrincipal;
    public Transform PosicaoPlayer;

    void Start()
    {
        SpawnTile(0);
        SpawnTile(0);
        SpawnTile(0);
        SpawnTile(0);
        SpawnTile(0);
        SpawnTile(0);
        SpawnTile(0);
        SpawnTile(0);
    }

    void Update()
    {
        if(PosicaoPlayer.position.z > zSpawn - (NumeroPistas * Pistas.Length)){
            SpawnTile(0);
        }
    }

    IEnumerator SpawnaEstrada(){
        SpawnTile(0);
        yield return new WaitForSeconds(10);
    }

    public void SpawnTile(int tileIndex){
        Instantiate(Pistas[tileIndex], new Vector3(ObjetoPrincipal.transform.position.x, ObjetoPrincipal.transform.position.y, zSpawn), transform.rotation);
        zSpawn += tamanhoPista;
    }

}
