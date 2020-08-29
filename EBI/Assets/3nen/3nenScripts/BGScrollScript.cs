using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrollScript : MonoBehaviour
{
    public GameObject bgPurple;
    public GameObject bgBlue;
    public GameObject bgCol;
    public GameObject bgPurple2;
    public GameObject bgBlue2;
    public GameObject bgCol2;

    public Transform bgPoint;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("BGColPurple"))
        {
            bgPurple.transform.position = bgPoint.position;
        }
        if (col.gameObject.CompareTag("BGColBlue"))
        {
            bgBlue.transform.position = bgPoint.position;
        }
        if (col.gameObject.CompareTag("BGColPurple2"))
        {
            bgPurple2.transform.position = bgPoint.position;
        }
        if (col.gameObject.CompareTag("BGColBlue2"))
        {
            bgBlue2.transform.position = bgPoint.position;
        }
    }
}
