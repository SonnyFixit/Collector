using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketManager : MonoBehaviour
{

    public GameObject BasketPrefab;

    public float basketBottomLine = -8f;

    //Na próbę
    public List<GameObject> baskets;
    



    // Start is called before the first frame update
    void Start()
    {
        GameObject BasketGo = Instantiate<GameObject>(BasketPrefab);
        Vector3 pos = Vector3.zero;
        pos.y = basketBottomLine;
        BasketGo.transform.position = pos;
        baskets.Add(BasketGo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlumOut()
    {
        GameObject[] PlumArray = GameObject.FindGameObjectsWithTag("Plum");

        foreach (GameObject plumplum in PlumArray)
        {
            Destroy(plumplum);
        }

        int basketIndex = baskets.Count - 1;
        GameObject currentBasket = baskets[basketIndex];
        baskets.RemoveAt(basketIndex);
        Destroy(currentBasket);

        if (baskets.Count == 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    
}
