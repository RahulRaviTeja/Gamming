using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool pause;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                resumegame();
            }
            else
            {
                pausegame();
            }
            Debug.Log("Escape");
        }
       
    }

   public void pausegame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }
    public void resumegame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }
    public void mainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScreen");
    }
    public void quit()
    {
        Application.Quit(); 
    }

}
