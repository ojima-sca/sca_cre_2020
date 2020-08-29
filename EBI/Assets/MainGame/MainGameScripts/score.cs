using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public static int mm;
    public static float  cm;
    private float oldmm;
    public static Text ScoeText;

    float scoreR;

    public void ScorePlus_s()
    {//スコア＋
        mm += 5;
    }
    public void ScorePlus_m()
    {
        mm += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        mm = 1;
        cm = 0;
        ScoeText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mm >= 10)
        {
            cm++;
            mm = mm - 10;
        }
        //テキスト更新
        if ((int)mm != (int)oldmm)
        {
            ScoeText.text = cm.ToString("00") + "." + ((int)mm).ToString("0");
        }
        oldmm = mm;

        //scoreR = cm + mm;
        //Debug.Log(scoreR);
    }

    public static int GetMM()
    {
        return mm;
    }

    public static float GetCM()
    {
        return cm;
    }
}
