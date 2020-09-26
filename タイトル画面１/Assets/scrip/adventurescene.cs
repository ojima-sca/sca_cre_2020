using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adventurescene : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("adventure1");
    }
}
