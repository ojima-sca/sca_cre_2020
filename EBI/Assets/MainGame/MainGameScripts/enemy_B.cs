using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_B : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float change=3f;
    private float count;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count >= change)
        {
            count = 0f;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D Dead)
    {
        if (Dead.gameObject.CompareTag("Player"))
        {
            Debug.Log("死亡しました");
            GameObject.Find("Player").GetComponent<pc>().Death();
        }
    }
}
