using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [Header("Controlador da garagem - será implementado no futuro")]
    public int CarroSelecionado;
    public GameObject[] CarrosDisponiveis;
    public GameObject ControladorCarro;

    void Start()
    {
        switch(CarroSelecionado){
            case 0: 
                ControladorCarro.transform.GetChild(0).gameObject.SetActive(true);
            break;
            
            case 1: 
                ControladorCarro.transform.GetChild(1).gameObject.SetActive(true);
            break;

        }
    }
}
