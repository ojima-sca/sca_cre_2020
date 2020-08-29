using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorePlus_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            GameObject.Find("ScoreText").GetComponent<score>().ScorePlus_m();
            Destroy(gameObject);
        }
    }
}
