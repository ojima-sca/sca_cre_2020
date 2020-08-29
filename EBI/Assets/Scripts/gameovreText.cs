using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameovreText : MonoBehaviour
{
    public GameObject GameovreText;
    // Start is called before the first frame update
    void Start()
    {
        GameovreText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameovreText.SetActive(pc.Hit);
        if (pc.Hit == true)
        {

        }
    }
    public void OnClick()
    {
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;
        SceneManager.sceneLoaded += GameScenLoaded;

    }
    private void GameScenLoaded(Scene next, LoadSceneMode mode)
    {
        var gameManager = GameObject.Find("ScoreText").GetComponent<score>();

        SceneManager.sceneLoaded -= GameScenLoaded;
    }
}
