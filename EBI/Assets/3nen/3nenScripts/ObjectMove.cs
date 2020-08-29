using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v2 = transform.position;

        v2.x -= Time.deltaTime * 1f;

        transform.position = v2;
    }
}
