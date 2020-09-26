using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScoreScript : MonoBehaviour
{

    public Text ScoreText;

    public string[] Menu = new string[15];

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Score", 3f);
        Menu[0] = ("エビピラフ");
        Menu[1] = ("シーフードピザ");
        Menu[2] = ("クリームパスタ");
        Menu[3] = ("エビ寿司");
        Menu[4] = ("ポップコーンシュリンプ");
        Menu[5] = ("エビフライ");
        Menu[6] = ("天丼");
        Menu[7] = ("串焼き");
        Menu[8] = ("エビグラタン");
        Menu[9] = ("伊勢海老のパエリア");
        Menu[10] = ("えび天");
        Menu[11] = ("伊勢海老の刺身");
        Menu[12] = ("ロブスターのサラダ");
        Menu[13] = ("巨大エビフライ");
        Menu[14] = ("グリル焼き");



    }

    // Update is called once per frame
    void Update()
    {

    }

    void Score()
    {

        ScoreText.text = string.Format(score.cm + "." + score.mm + "cmの" + Menu[Result_EbiScroll.Picu_UP], transform.position, transform.rotation+ "！" );
    }
  

}
