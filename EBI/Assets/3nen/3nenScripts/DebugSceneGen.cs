using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugSceneGen : MonoBehaviour
{
    Animator anim;

    //オブジェクト
    public GameObject BlackWall; //フェードアウト再生用のBlackWall取得
    //数値

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void MainGame()
    {
        BlackWall.GetComponent<Animator>().SetBool("isFadeOut", true); //取得したオブジェクトからフェードアウト再生
        Invoke("GoMainGame",1.5f);
    }

    public void AD1()
    {
        BlackWall.GetComponent<Animator>().SetBool("isFadeOut",true); //取得したオブジェクトからフェードアウト再生
        Invoke("GoAD1",1.5f);
    }

    public void AD2()
    {
        BlackWall.GetComponent<Animator>().SetBool("isFadeOut", true); //取得したオブジェクトからフェードアウト再生
        Invoke("GoAD2",1.5f);
    }

    public void AD3()
    {
        BlackWall.GetComponent<Animator>().SetBool("isFadeOut", true); //取得したオブジェクトからフェードアウト再生
        Invoke("GoAD3", 1.5f);
    }

    public void AD4()
    {
        BlackWall.GetComponent<Animator>().SetBool("isFadeOut", true); //取得したオブジェクトからフェードアウト再生
        Invoke("GoAD4", 1.5f);
    }

    public void GoMainGame()
    {
        SceneManager.LoadScene("main");
    }

    public void GoAD1()
    {
        SceneManager.LoadScene("adventur1");
    }

    public void GoAD2()
    {
        SceneManager.LoadScene("adventure2-1");
    }

    public void GoAD3()
    {
        SceneManager.LoadScene("Adventure3");
    }

    public void GoAD4()
    {
        SceneManager.LoadScene("Adventure4");
    }
}
