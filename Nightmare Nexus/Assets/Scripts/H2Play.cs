using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class H2Play : MonoBehaviour
{
    private int procede = 7;
    private int goBack = 0;
    public int procedeeee = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void proced()
    {
        SceneManager.LoadScene(procede);
    }
    public void procedee()
    {
        SceneManager.LoadScene(procedeeee);
    }
    public void goback()
    {
        SceneManager.LoadScene(goBack);
    }
}
