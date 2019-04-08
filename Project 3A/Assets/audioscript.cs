using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class audioscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AudioSource gamemusic = GameObject.Find("audio").GetComponent<AudioSource>();
        gamemusic.volume = PlayerPrefs.GetFloat("musicvolume");

    }

    private void Awake()
    {


        int numMusicPlayers = FindObjectsOfType<AudioSource>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(this.gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
