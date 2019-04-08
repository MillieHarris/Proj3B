using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletcollision : MonoBehaviour
{

    public int score;
    private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scorecontroller scorescript = GetComponent<scorecontroller>();



  /*      bullet = GameObject.Find("bullet");

        bullet.transform.Translate(Vector3.forward * Time.deltaTime); */


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject scoreobj = GameObject.Find("Canvas");
        scorecontroller scorescript = scoreobj.GetComponent<scorecontroller>();
    

    /*    GameObject bullets = GameObject.Find("ship");
        moveship shipscript = bullets.GetComponent<moveship>();

        GameObject explode = GameObject.Find("explosion");
        GameObject oneexplode = Instantiate(explode);
        oneexplode.transform.position = shipscript.bulletprefab.transform.position; */

        if (collision.gameObject.tag == "asteroid")
        {

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            scorescript.score += 10;
         /*   ParticleSystem explosion = oneexplode.GetComponent<ParticleSystem>();
            explosion.Play(); */

        }

        if (collision.gameObject.tag == "comet")
        {

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            scorescript.score += 30;
            /*   ParticleSystem explosion = oneexplode.GetComponent<ParticleSystem>();
               explosion.Play(); */

        }

        if (collision.gameObject.tag == "edge")
        { Destroy(this.gameObject); }
    }

}
