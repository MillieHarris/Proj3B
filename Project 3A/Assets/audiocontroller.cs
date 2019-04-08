using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audiocontroller : MonoBehaviour
{

    public Toggle mutemusic;
    public Slider musicvol;
    public Toggle mutesfx;
    public Slider sfxvol;


    // Start is called before the first frame update
    void Start()
    {

        mutemusic.isOn = false;
        mutesfx.isOn = false;
        musicvol.value = .5f;
        sfxvol.value = .5f;


    }

    // Update is called once per frame
    void Update()
    {


        if (mutemusic.isOn == false)
        {
            PlayerPrefs.SetFloat("musicvolume", musicvol.value);
        }

        if (mutesfx.isOn == false)
        { PlayerPrefs.SetFloat("sfxvolume", sfxvol.value); }


    }



    public void lowermusic()
    {

        PlayerPrefs.SetFloat("musicvolume", musicvol.value);

    }

    public void mutemusicfunc()
    {

        PlayerPrefs.SetFloat("musicvolume", 0);

    }

    public void lowersfx()
    {
        PlayerPrefs.SetFloat("sfxvolume", sfxvol.value);

    }

    public void mutesfxfunc()
    {
        PlayerPrefs.SetFloat("sfxvolume", 0);

    }
}
