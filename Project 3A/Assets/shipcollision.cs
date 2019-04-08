using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcollision : MonoBehaviour
{
    public AudioSource explodesource;
    public AudioClip explodeclip;


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
        GameObject lifeobj = GameObject.Find("Canvas");
        scorecontroller lifescript = lifeobj.GetComponent<scorecontroller>();



        GameObject shipobj = GameObject.Find("Canvas");
        moveship shipscript = shipobj.GetComponent<moveship>();

        if (collision.gameObject.tag == "asteroid")
        {
            shipscript.ship.velocity = Vector3.zero;
            shipscript.ship.angularVelocity = 0;
            shipscript.shipobject.transform.position = new Vector3(0, 0, 0);
            Destroy(collision.gameObject);
            lifescript.lives -= 1;


        }

        if (collision.gameObject.tag == "powerup")
        { shipscript.ship.angularVelocity = 0; }

        if (collision.gameObject.tag == "comet")
        {
            shipscript.ship.velocity = Vector3.zero;
            shipscript.ship.angularVelocity = 0;
            shipscript.shipobject.transform.position = new Vector3(0, 0, 0);
            Destroy(collision.gameObject);
            lifescript.lives -= 1;


        }



    }

}
