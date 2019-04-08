using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cometmove : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject shipobj = GameObject.Find("ship");
        shipcollision explodesound = shipobj.GetComponent<shipcollision>();

        if (collision.gameObject.tag == "ship")
        {

            GameObject particles = GameObject.Find("explosion");
            ParticleSystem explosion = particles.GetComponent<ParticleSystem>();
            explosion.Play();


            explodesound.explodesource.volume = PlayerPrefs.GetFloat("sfxvolume");
            explodesound.explodesource.PlayOneShot(explodesound.explodeclip);
        }


        if (collision.gameObject.tag == "edge")
        { Destroy(this.gameObject); }

        if (collision.gameObject.tag == "bullet")
        {
            explodesound.explodesource.volume = PlayerPrefs.GetFloat("sfxvolume");
            explodesound.explodesource.PlayOneShot(explodesound.explodeclip);
        }
    }




}
