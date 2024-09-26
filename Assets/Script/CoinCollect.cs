using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    GameController gameController; 
    void Start()
    {
        if (gameController == null)
        {
            gameController = GameObject.Find("GameController").GetComponent<GameController>();
        }
    }

    
    void Update()
    {
        
        if (gameController.getItem)
        {
            Debug.Log("Get Item");
            StartCoroutine(WaitforTaking(4.7f));
            Destroy(this.gameObject);
            gameController.getItem = false;
        }
    }

    IEnumerator WaitforTaking(float time)
    {
        yield return new WaitForSeconds(time);
    }
}