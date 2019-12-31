using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    public GameObject treePrefab;

    public float speed = 3f;
    public float edge = 10f;
    public float changeDirectionChance = 0.01f;
    public float timeToDrop = 1f;


    // Start is called before the first frame update
    void Start()
    {

        Invoke( "Drop", 2f);
        
    }

    void Drop()
    {
        GameObject plum = Instantiate<GameObject>(treePrefab);
        plum.transform.position = transform.position;
        Invoke("Drop", timeToDrop);
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -edge)
        {
            speed = Mathf.Abs(speed);
        }

        else if (pos.x > edge)
        {
            speed = -Mathf.Abs(speed);
        }

        
        
    }

    void FixedUpdate()
    {
        if (Random.value < changeDirectionChance)
        {
            speed *= -1;
        }
    }

    

}
