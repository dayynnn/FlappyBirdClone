using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

   
}
