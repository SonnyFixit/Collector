
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{

    public Text score;

    // Start is called before the first frame update
    void Start()
    {

        GameObject scoreGO = GameObject.Find("ScoreCounter");
        score = scoreGO.GetComponent<Text>();
        score.text = "0";
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        transform.position = pos;
    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject collWith = collision.gameObject;

        if (collWith.tag == "Plum")
        {
            Destroy(collWith);

            int scoreX = int.Parse(score.text);

            scoreX += 50;

            score.text = scoreX.ToString();

            if (scoreX > HighScore.score)
            {
                HighScore.score = scoreX;
            }
        }
    }
}
