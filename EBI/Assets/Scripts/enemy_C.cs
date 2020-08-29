using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_C : MonoBehaviour
{
    public float scroll;
    Rigidbody2D rb2b;

    //3年追加
    bool canMove = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2b = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            Move();
        }
    }

    public void OnTriggerEnter2D(Collider2D Col)
    {
        //3年追加
        if (Col.gameObject.CompareTag("EnemyCGene"))
        {
            canMove = true;
        }

        //死亡処理
        if (Col.gameObject.CompareTag("Player"))
        {
            Debug.Log("死亡しました");
            GameObject.Find("Player").GetComponent<pc>().Death();
        }
    }

    void Move()
    {
        rb2b.velocity = new Vector2(scroll, rb2b.velocity.y);
    }

}

