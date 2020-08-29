using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pc : MonoBehaviour
{
    public GameObject Player;
    public float flap = 10f;
    public float scroll = 10f;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    public static bool Hit;

    //3年追加
    public GameObject gameOver; //ゲームオーバー画像取得
    public GameObject WhiteOut; 

    public void Death()
    {
        Hit = true;
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;

        //3年追加
        gameOver.SetActive(true); //死亡時ゲームオーバー画像表示
        WhiteOut.GetComponent<Animator>().SetBool("isGameOver", true);
    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Hit = false;
    }

    // Update is called once per frame
    void Update()
    {//x方向に移動
      rb2d.velocity = new Vector2(scroll, rb2d.velocity.y);
     

        // スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 落下速度をリセット
            rb2d.velocity = Vector2.zero;
            // (0,1)方向に瞬間的に力を加えて跳ねさせる
            rb2d.AddForce(Vector2.up * flap, ForceMode2D.Impulse);
        }
    }
}
