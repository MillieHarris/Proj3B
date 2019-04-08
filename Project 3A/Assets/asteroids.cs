using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroids : MonoBehaviour
{

    public Sprite asteroid;
    public Vector3 direction;
    public int speed = 3;
    public GameObject astcontainer;
    public GameObject asteroidprefab;
    public float topbot;
    public float rightleft;
    public float twoops;
    public AudioSource explodesource;
    public AudioClip explodeclip;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("spawnasteroid", 1, 1);



    }

    // Update is called once per frame
    void Update()
    {
        topbot = Random.value;
        rightleft = Random.value;
        twoops = Random.value;

        /*if( 0 > GameObject.Find("rigidbody").transform.position.x || Screen.width < GameObject.Find("rigidbody").transform.position.x)
        { Destroy(GameObject.Find("rigidbody")); }

        if (0 > GameObject.Find("rigidbody").transform.position.y || Screen.height < GameObject.Find("rigidbody").transform.position.y)
        { Destroy(GameObject.Find("rigidbody")); }
        */

    }

    public void spawnasteroid()
    {


        GameObject newasteroid = Instantiate(asteroidprefab);

        if (twoops >= 0.5f)
        {
            //spawn top
            if (topbot >= 0.5f)
            {
                Vector3 newpos = new Vector3(Random.Range(-7,7), 5.65f, 0);
                newasteroid.transform.Translate(newpos);
                direction = new Vector3(Random.Range(-1f, 1f), -1, 0);
                Rigidbody2D asteroidbody = newasteroid.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * speed;
                newasteroid.transform.SetParent(astcontainer.transform);
            }

            //spawn bot
            if (topbot < 0.5f)
            {
                Vector3 newpos = new Vector3(Random.Range(-7,7), -5.45f, 0);
                newasteroid.transform.Translate(newpos);
                direction = new Vector3(Random.Range(-1f, 1f), 1, 0);
                Rigidbody2D asteroidbody = newasteroid.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * speed;
                newasteroid.transform.SetParent(astcontainer.transform);
            }
        }

        if (twoops < .5f)
        { 
            //spawn left
            if (rightleft <= .5f)
            {
                Vector3 newpos = new Vector3(-7, Random.Range(-5.45f,5.65f), 0);
                newasteroid.transform.Translate(newpos);
                direction = new Vector3(1,Random.Range(-1f,1f),0);
                Rigidbody2D asteroidbody = newasteroid.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * speed;
                newasteroid.transform.SetParent(astcontainer.transform);
            }

            //spawn right
            if (rightleft > .5f)
            {
                Vector3 newpos = new Vector3(7, Random.Range(-5.45f,5.65f), 0);
                newasteroid.transform.Translate(newpos);
                direction = new Vector3(-1, Random.Range(-1f, 1f), 0);
                Rigidbody2D asteroidbody = newasteroid.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * speed;
                newasteroid.transform.SetParent(astcontainer.transform);
            }
        }

    }

    

}
