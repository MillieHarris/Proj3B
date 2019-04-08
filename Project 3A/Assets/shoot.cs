using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
  //  public GameObject bullets;
    public int speed = 4;
   // public GameObject container;
    //public GameObject bulletinstance;
    public AudioClip shootaud;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp("space"))
        { SpawnPrefab(); }

     //   bullets.transform.Translate(bullets.transform.up * speed * Time.deltaTime);

    }


    public void SpawnPrefab()
    {
        moveship ship = GetComponent<moveship>();
       // bulletinstance = Instantiate(bullets, ship.ship.transform.position, Quaternion.identity);
    }
}