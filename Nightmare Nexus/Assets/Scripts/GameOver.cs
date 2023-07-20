using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private int MM = 0;
    private int rtry = 2;
    private int trolQuit = 5;
    private int realquit = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(MM);
    }
    public void retry()
    {
        SceneManager.LoadScene(rtry);
    }
    public void quit()
    {
        SceneManager.LoadScene(trolQuit);
    }
    public void  Proced()
    {
        SceneManager.LoadScene(realquit);
    }
    public void realQuit()
    {
        Application.Quit();
    }
}
