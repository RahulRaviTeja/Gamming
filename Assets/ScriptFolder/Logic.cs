using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Logic : MonoBehaviour
{

    public int playerscore;
    public Text scoretext;
    [SerializeField] TextMeshProUGUI HighScoreText;
    public GameObject gameoverscreen;
    public AudioSource music;
    public AudioSource SFX;
    public AudioClip ding;
    public AudioClip background;
    public AudioClip Crash;

    private void Start()
    {
        music.clip = background;
        music.Play();
        Updatehighscore();
    }


    [ContextMenu("IncreaseScore")]
    public void Addscore(int Addscore)
    {
        playerscore += Addscore;
        scoretext.text=playerscore.ToString();
        SFX.clip = ding;
        SFX.Play();
    }

    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  public  void gameover()
    {
        gameoverscreen.SetActive(true);
        SFX.clip = Crash;
        SFX.Play();

    }
    
    void CheckHighscore()
    {
        if (playerscore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerscore);
            Updatehighscore();
           
        }
    }

    void Updatehighscore()
    {
        HighScoreText.text = $"HighScore : {PlayerPrefs.GetInt("HighScore", 0)}";
       
    }

    private void Update()
    {
        CheckHighscore();
    }

    public void Backtomain()
    {
        SceneManager.LoadScene("TitleScreen");
    } 
}
