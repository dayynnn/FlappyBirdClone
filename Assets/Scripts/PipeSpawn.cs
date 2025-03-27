using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] private float heightRange = 0.99f;
    [SerializeField] private float totalTime = 2f;
    [SerializeField] private GameObject pipes;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > totalTime) 
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector2 spawnPoint = (Vector2)transform.position + new Vector2(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(pipes, spawnPoint, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
