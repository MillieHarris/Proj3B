using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasercollision : MonoBehaviour
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

        GameObject scoreobj = GameObject.Find("Canvas");
        scorecontroller scorescript = scoreobj.GetComponent<scorecontroller>();

        if (collision.gameObject.tag == "asteroid")
        {

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            scorescript.score += 10;

            GameObject particle = GameObject.Find("explosion");
            ParticleSystem explosion = particle.GetComponent<ParticleSystem>();
            explosion.Play();


            GameObject shipobj = GameObject.Find("ship");
            shipcollision explodesound = shipobj.GetComponent<shipcollision>();

            explodesound.explodesource.volume = PlayerPrefs.GetFloat("sfxvolume");
            explodesound.explodesource.PlayOneShot(explodesound.explodeclip);

        }


        if (collision.gameObject.tag == "comet")
        {

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            scorescript.score += 30;
            /*   ParticleSystem explosion = oneexplode.GetComponent<ParticleSystem>();
               explosion.Play(); */

        }
    }
}
