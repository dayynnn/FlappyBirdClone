using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float speed = 0.8f;

    void Update()
    {
       transform.Translate(Vector2.left * Time.deltaTime * speed);    
    }
}
