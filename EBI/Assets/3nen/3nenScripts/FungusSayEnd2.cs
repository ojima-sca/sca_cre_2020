using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FungusSayEnd2 : MonoBehaviour
{
    //public GameObject fadeOut;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ad2End();
    }

    void Ad2End()
    {
        if (Fungus.SayDialog.a == 2) //SayDialog内で会話をカウントし、2になったら
        {
            //FadeOut(); //画面を暗くする
            //Invoke("GoResult",2f) //画面が暗くなったらリザルトシーンへ
            GoResult();
            Fungus.SayDialog.a = 0; //会話カウント初期化
        }
    }

    void GoResult()
    {
        SceneManager.LoadScene("result_1");
    }

    void FadeOut()
    {
        //fadeOut.GetComponent<Animator>().SetBool("isFadeOut",true);
    }
}