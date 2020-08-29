using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonGenerator : MonoBehaviour
{
    public GameObject end;
    public GameObject retry;
    //public GameObject FadeOut;

    void Start()
    {
        Invoke("SetButtons",6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetButtons()
    {
        end.SetActive(true);
        retry.SetActive(true);
    }

    public void End()
    {
        SceneManager.LoadScene("Title");
    }

    public void Retry()
    {
        SceneManager.LoadScene("main");
    }
}
