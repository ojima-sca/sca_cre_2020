using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_A : MonoBehaviour
{
    public float scroll = 10f;
    Rigidbody2D rb2d;
    Vector2 defaultPos;
    public float vertcal;
    
    // Start is called before the first frame update
    void Start()
    {
       
        rb2d = GetComponent<Rigidbody2D>();
        defaultPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(scroll, rb2d.velocity.y);
        //transform.position = new Vector2((transform.position.x) , Mathf.Clamp( transform.position.y,max_y,min_y));
 
       // GameObject.Find(""). GetComponent<pc>().Dead();
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(new Vector2(defaultPos.x, defaultPos.y  + Mathf.PingPong(Time.time,vertcal)));
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
