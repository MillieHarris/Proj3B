using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{


    public GameObject laserprefab;
    public Vector3 direction;
    public float counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (counter == 1 && counter > 0)
        { counter -= Time.deltaTime; }

    }


    public void spawnlaser()
    {
        GameObject power = GameObject.Find("powerup");
        powercollision powerscript = power.GetComponent<powercollision>();

        counter = 1;

        GameObject laserinstance = Instantiate(laserprefab);

    }



}
