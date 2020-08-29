using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stop : MonoBehaviour
{
    public GameObject Stop;
    public static bool pause;
    public void OnClik()
    {
        pause =! pause;
        //ポーズボタンで一時停止
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;
        Debug.Log("押された!");  // ログを出力
        
    }

    // Start is called before the first frame update
    void Start()
    {
        pause = false;
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    //3年追加
    public bool GetPause()
    {
        return pause;
    }
}
