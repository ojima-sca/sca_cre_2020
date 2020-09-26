using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result_EbiScroll : MonoBehaviour
{
    public float scroll = 10f;
    Rigidbody2D rb2d;
    public GameObject[] menu;
    public static int Picu_UP;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("Picu", 3f);
        Picu_UP = Random.Range(0, 15);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DOWN", 0f);
    }
    private void UP()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, -scroll);
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, 10, 0));
        
    }
    private void DOWN()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, scroll);
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, 0, 10));

    }
    public void Picu()
    {
        Instantiate(menu[Picu_UP], transform.position, transform.rotation);
    }

}
