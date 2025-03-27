using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    [SerializeField] private float velocity = 2f;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private AudioClip flapAudio;
    [SerializeField] private AudioClip deathAudio;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            rb.velocity = Vector2.up * velocity;
            SoundManager.instance.PlaySound(flapAudio);
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.instance.PlaySound(deathAudio);
        GameManager.instance.GameOver();
    }
}
