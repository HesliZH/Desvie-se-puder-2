using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Alvo;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - Alvo.position;
    }

    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z+Alvo.position.z);
        transform.position = newPosition;        
    }
}
