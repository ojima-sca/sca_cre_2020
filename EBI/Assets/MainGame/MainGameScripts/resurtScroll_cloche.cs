using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resurtScroll_cloche : MonoBehaviour
{
    public float scroll = 10f;
    Rigidbody2D rb2d;

    private void DOWN()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, scroll);
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, 0, 10));
    }
    private void UP()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, -scroll);
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, 10, 0));

    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("DOWN", 0f);
        Invoke("UP",3f);
    }

    // Update is called once per frame
    void Update()
    {
        //rb2d.velocity = new Vector2(rb2d.velocity.x, scroll);
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, 0, 10));


    }
}
