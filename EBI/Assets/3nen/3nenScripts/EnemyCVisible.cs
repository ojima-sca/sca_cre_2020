using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCVisible : MonoBehaviour
{
    Renderer target;

    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target.isVisible)
        {
            Debug.Log("画面に映っているよ");
        }
        else
        {
            Debug.Log("画面に映っていないよ");
        }
    }
}
