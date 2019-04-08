using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{

    public GameObject powerprefab;
    public float xpos;
    public float ypos;
    public AudioSource powersound;
    public AudioClip powerclip;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnpower", 10, 20);
    }

    // Update is called once per frame
    void Update()
    {


        xpos = Random.Range(-7.4f, 7.5f);
        ypos = Random.Range(-4.4f, 4.5f);

    }



    public void spawnpower()
    {


        GameObject instance = Instantiate(powerprefab);
        instance.transform.position = new Vector3(xpos, ypos, instance.transform.position.z);



    }




}
