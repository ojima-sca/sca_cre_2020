using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    public GameObject Title;
 
    // Start is called before the first frame update
    void Start()
    {
        Title.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // Title.SetActive(stop.pause);
        if (stop.pause == true)
        {
            Title.SetActive(true);
        }
        else
        {
            Title.SetActive(false);
        }
    }
    public void OnTitle()
    {

        Time.timeScale = 1f;
        //タイトルをロードする
        SceneManager.LoadScene("Title");

        //Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;
    }
}
