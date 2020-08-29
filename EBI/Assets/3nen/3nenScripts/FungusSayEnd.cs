using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FungusSayEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TitleEnd();
    }

    void TitleEnd()
    {
        if (Fungus.SayDialog.a == 2)
        {
            Fungus.SayDialog.a = 0;
            Invoke("GoMain",1f);
        }
    }

    void GoMain()
    {
        SceneManager.LoadScene("main");
    }
}
