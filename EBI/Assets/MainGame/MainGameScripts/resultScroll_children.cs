using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultScroll_children : MonoBehaviour
{
    public float scroll = 10f;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(scroll, rb2d.velocity.y);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, 7, 13)
            , transform.position.y);
    }
}
