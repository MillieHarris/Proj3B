using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscores : MonoBehaviour
{

    int[] highscores1 = new int[10];
    public int highscore;
    public string highScoreKey;
    public int score;
    public int i;
    public Text first;
    public Text second;
    public Text third;
    public Text fourth;
    public Text fifth;
    public Text sixth;
    public Text seventh;
    public Text eighth;
    public Text ninth;
    public Text tenth;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        
    }

    // Update is called once per frame
    void Update()
    {
        for (i = 0; i < highscores1.Length; i++)
        {

            //Get the highScore from 1 - 5
            highScoreKey = "HighScore" + (i + 1).ToString();
            highscore = PlayerPrefs.GetInt(highScoreKey, 0);

            if (score > highscore)
            {
                int temp = highscore;
                PlayerPrefs.SetInt(highScoreKey, score);
                score = temp;
            }


        }


        first.text = "First: " + PlayerPrefs.GetInt("HighScore1");
        second.text = "Second: " + PlayerPrefs.GetInt("HighScore2");
        third.text = "Third: " + PlayerPrefs.GetInt("HighScore3");
        fourth.text = "Fourth: " + PlayerPrefs.GetInt("HighScore4");
        fifth.text = "Fifth: " + PlayerPrefs.GetInt("HighScore5");
        sixth.text = "Sixth: " + PlayerPrefs.GetInt("HighScore6");
        seventh.text = "Seventh: " + PlayerPrefs.GetInt("HighScore7");
        eighth.text = "Eighth: " + PlayerPrefs.GetInt("HighScore8");
        ninth.text = "Ninth: " + PlayerPrefs.GetInt("HighScore9");
        tenth.text = "Tenth: " + PlayerPrefs.GetInt("HighScore10");
    }
}
