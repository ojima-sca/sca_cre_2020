using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainscene : MonoBehaviour
{
    public void OnClickstartButton()
    {
        SceneManager.LoadScene("Maingame");
    }
}
