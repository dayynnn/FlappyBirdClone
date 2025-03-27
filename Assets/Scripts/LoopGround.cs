using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float width = 6f;

    private SpriteRenderer sprite;
    private Vector2 startSize;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        startSize = new Vector2(sprite.size.x, sprite.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        sprite.size = new Vector2(sprite.size.x + speed, sprite.size.y + speed);

        if(sprite.size.x > width)
        {
            sprite.size = startSize;
        }
    }
}
