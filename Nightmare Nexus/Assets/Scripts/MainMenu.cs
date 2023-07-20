using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int nexus = 2;
    private int H2P = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Selection()
    {
        SceneManager.LoadScene(nexus);
    }
    public void How2p()
    {
        SceneManager.LoadScene(H2P);
    }
    public void quit()
    {
        Application.Quit();
    }
}
