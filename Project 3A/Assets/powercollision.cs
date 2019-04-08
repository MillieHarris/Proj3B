using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powercollision : MonoBehaviour
{
    public float counter;
    public bool didfunction = false;
    public Vector3 direction;
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        /*  GameObject laserfab = GameObject.Find("Canvas");
          laser laserscript = laserfab.GetComponent<laser>();

          if (counter > 0 && counter < 5)
              if (Input.GetKeyDown("space"))

              {
                  counter -= 1;


              }

          if (counter == 0)
          { counter = 5; }

          } */
    }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            GameObject canvas = GameObject.Find("Canvas");
            powerup powerupsound = canvas.GetComponent<powerup>();

            GameObject laserobj = GameObject.Find("Canvas");
            laser laserscript = laserobj.GetComponent<laser>();

            if (collision.gameObject.tag == "ship")
            {


                GameObject particles = GameObject.Find("powerup");
                ParticleSystem power = particles.GetComponent<ParticleSystem>();
                power.Play();

                powerupsound.powersound.volume = PlayerPrefs.GetFloat("sfxvolume");
                powerupsound.powersound.PlayOneShot(powerupsound.powerclip);

                Destroy(this.gameObject);

                laserscript.spawnlaser();
                

                

                

            }



        }


    

}
