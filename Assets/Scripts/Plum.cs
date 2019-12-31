using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plum : MonoBehaviour
{
    public static float destroyPoint = -15f; 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < destroyPoint)
        {
            Destroy(this.gameObject);



            BasketManager bmScript = Camera.main.GetComponent<BasketManager>();
            bmScript.PlumOut();
        }

    }
}
