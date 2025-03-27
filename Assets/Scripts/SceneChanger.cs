using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private GameObject gameStartCanvas;
    //public static SceneChanger instance;
    private void Start()
    {
        gameStartCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Debug.Log("startin game");
        gameStartCanvas.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }
}
