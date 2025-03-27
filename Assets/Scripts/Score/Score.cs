using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI highScore;

    private int score;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentScore.text = score.ToString();
        
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); //not meant for large amount of data
        UpdateHighScore();
    }

    // Update is called once per frame
    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }
    }
    public void UpdateScore()
    {
        score++;
        currentScore.text = score.ToString();
        UpdateHighScore();
    }
}
