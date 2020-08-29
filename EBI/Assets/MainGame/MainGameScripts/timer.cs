using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    //3年追加
    public GameObject TimeUp;
    public GameObject WhiteOut;

    public static bool timeout;
    [SerializeField]
   public float seconds;
    //　前のUpdateの時の秒数
    private float oldSeconds;
    //　タイマー表示用テキスト
    private Text timerText;
    private timer GetTimer;
    // Start is called before the first frame update
    public void TimerPlus()
    {//タイマーの追加秒数
        this.seconds += 5;
    }
    public GameObject[] number;
    void Start()
    {
        seconds = 30.9f;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
        timeout = false;
    }
    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
          //　値が変わった時だけテキストUIを更新
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text =  ((int)seconds).ToString("00" + " 秒");
        }
          oldSeconds = seconds;
        //　制限時間以下になったらコンソールに『制限時間終了』という文字列を表示する
        if (seconds <= 0.9f)
        {
            Debug.Log("制限時間終了");
            seconds = 0;
            timeout = true;

            //3年追加
            TimeUp.SetActive(true);
            WhiteOut.GetComponent<Animator>().SetBool("isGameOver", true);
        }
        if (timeout == true)
        {
            Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;
            enabled = false;
        }
        //　マウスの左ボタン押しで一時停止
       // if (Input.GetMouseButtonDown(0))
        //{
        //  Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;
        //}
        
    }
}
