using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comet : MonoBehaviour
{

    public GameObject cometprefab;
    public GameObject cometcontainer;
    public float topbot;
    public float rightleft;
    public float twoops;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawncomet", 1, 6);
    }

    // Update is called once per frame
    void Update()
    {


        topbot = Random.value;
        rightleft = Random.value;
        twoops = Random.value;

    }

    public void spawncomet()
    { GameObject newcomet = Instantiate(cometprefab);

        if (twoops >= 0.5f)
        {
            if (topbot >= 0.5f)
            {
                Vector3 newpos = new Vector3(Random.Range(-7, 7), 5.65f, 0);
                newcomet.transform.Translate(newpos);
                direction = new Vector3(Random.Range(-1f, 1f), -1, 0);
                Rigidbody2D asteroidbody = newcomet.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * 10;
                newcomet.transform.SetParent(cometcontainer.transform);
            }

            if (topbot < 0.5f)
            {
                Vector3 newpos = new Vector3(Random.Range(-7, 7), -5.45f, 0);
                newcomet.transform.Translate(newpos);
                direction = new Vector3(Random.Range(-1f, 1f), 1, 0);
                Rigidbody2D asteroidbody = newcomet.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * 10;
                newcomet.transform.SetParent(cometcontainer.transform);
            }
        }

        if (twoops < .5f)
        {
            //spawn left
            if (rightleft <= .5f)
            {
                Vector3 newpos = new Vector3(-7, Random.Range(-5.45f, 5.65f), 0);
                newcomet.transform.Translate(newpos);
                direction = new Vector3(1, Random.Range(-1f, 1f), 0);
                Rigidbody2D asteroidbody = newcomet.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * 10;
                newcomet.transform.SetParent(cometcontainer.transform);
            }

            //spawn right
            if (rightleft > .5f)
            {
                Vector3 newpos = new Vector3(7, Random.Range(-5.45f, 5.65f), 0);
                newcomet.transform.Translate(newpos);
                direction = new Vector3(-1, Random.Range(-1f, 1f), 0);
                Rigidbody2D asteroidbody = newcomet.GetComponent<Rigidbody2D>();
                asteroidbody.velocity = direction * 10;
                newcomet.transform.SetParent(cometcontainer.transform);
            }
        }






    }
}
