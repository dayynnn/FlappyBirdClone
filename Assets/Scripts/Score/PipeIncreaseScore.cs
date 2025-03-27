using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    [SerializeField] private AudioClip scoreAudio;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SoundManager.instance.PlaySound(scoreAudio);
            Score.instance.UpdateScore();
        }
    }
}
