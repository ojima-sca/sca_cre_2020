using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScoreScript : MonoBehaviour
{

    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Score",3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Score()
    {

        ScoreText.text = string.Format(score.cm + "." + score.mm + "cm" + "のエビフライ！");
    }
}
