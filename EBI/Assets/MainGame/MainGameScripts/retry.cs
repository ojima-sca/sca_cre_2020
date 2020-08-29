using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour
{
    public GameObject Retry;
   
    // Start is called before the first frame update
    void Start()
    {
       Retry.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Retry.SetActive(stop.pause);
    }
    public void OnRetry()
    {
        //メインをロードする
        //SceneManager.LoadScene("main");

        //3年追加
        stop.pause = false; //ゲームに戻ったらポーズUI非表示

        Time.timeScale = 1f; //ゲームに戻ったら時間再開
    }
}
