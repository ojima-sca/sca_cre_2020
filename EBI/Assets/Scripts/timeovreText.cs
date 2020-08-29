using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timeovreText : MonoBehaviour
{
    public GameObject TimeovreText;
    // Start is called before the first frame update
    void Start()
    {
        TimeovreText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TimeovreText.SetActive(timer.timeout);
        if (timer.timeout == true)
        {
         
        }

    }
    public void timeovre()
    {
        
    }
    public void OnClick()
    {
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;
        SceneManager.sceneLoaded += GameScenLoaded;
        
    }
    private void GameScenLoaded(Scene next,LoadSceneMode mode)
    {
        var gameManager = GameObject.Find("ScoreText").GetComponent<score>();
        
        SceneManager.sceneLoaded -= GameScenLoaded;
    }
}
