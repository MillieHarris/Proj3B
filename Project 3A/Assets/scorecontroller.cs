using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class scorecontroller : MonoBehaviour
{
    public float CurrentTime;
    public Text time;
    public int score=0;
    public Text scoretxt;
    public int lives = 3;
    public Text livestxt;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = 200;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        if (CurrentTime <= 0)
        { EndGame(); }

        if (lives == 0)
        { SceneManager.LoadScene("endscreen"); }

        time.text = "Time: " + CurrentTime;
        scoretxt.text = "Score: " + score;
        livestxt.text = "Lives: " + lives;

        PlayerPrefs.SetInt("score", score);
    }

    public void EndGame()
    { SceneManager.LoadScene("endscreen"); }

}
