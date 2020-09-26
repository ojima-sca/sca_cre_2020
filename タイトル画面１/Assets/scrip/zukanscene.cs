using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zukanscene : MonoBehaviour
{
    public void OnclickStartButton()
    {
        SceneManager.LoadScene("zukann");//シーン名図鑑
    }
}
