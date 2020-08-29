using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            anim.SetBool("isJump",true);
            Invoke("AnimOff",0.35f);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("isGround",true);
        }
        else
        {
            anim.SetBool("isGround", false);
        }
    }

    void AnimOff()
    {
        anim.SetBool("isJump",false);
    }
}
