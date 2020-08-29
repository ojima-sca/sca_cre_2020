using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseText;
    public GameObject Pause_back;

    // Start is called before the first frame update
    void Start()
    {
        PauseText.SetActive(false);
        Pause_back.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PauseText.SetActive(stop.pause);
        Pause_back.SetActive(stop.pause);
    }
}
