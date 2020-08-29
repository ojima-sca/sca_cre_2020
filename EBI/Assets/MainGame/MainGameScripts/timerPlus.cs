using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerPlus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            //取得時タイマーを延ばす
            GameObject.Find("timerText").GetComponent<timer>().TimerPlus();
            //タイマーアイテムを非表示
            Destroy(gameObject);
        }
    }
}
