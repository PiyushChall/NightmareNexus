using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreValueText;
    public float scoreValue = 0f;
    public float scoreIncrement = 1f;
    public Text highScoreTxt;
    public float highScorevalue = 0f;

    private void Start()
    {
        highScorevalue = PlayerPrefs.GetFloat("HighScore");
    }
    void FixedUpdate()
    {
        scoreValueText.text = ((int)scoreValue).ToString();
        scoreValue += scoreIncrement * Time.fixedDeltaTime;
        highScoreTxt.text = ((int)highScorevalue).ToString();
        if(scoreValue > highScorevalue)
        {
            PlayerPrefs.SetFloat("HighScore", scoreValue);
        }
    }
}
