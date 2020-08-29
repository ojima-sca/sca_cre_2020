using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTimer : MonoBehaviour
{
    public GameObject[] Train;
    public float delete = 1f;
    private float seconds;
    // Start is called before the first frame update
    void Start()
    {
        seconds = 4f;
        Random.Range(0, Train.Length);
        Instantiate(Train[0], transform.position, transform.rotation);
        Destroy(gameObject,delete);
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (Train[3])
        {
            gameObject.SetActive(false);
        }
        else if (Train[2])
        {
            Instantiate(Train[3], transform.position, transform.rotation);
            Destroy(gameObject, delete);
        }
        else if (Train[1])
        {
            Instantiate(Train[2], transform.position, transform.rotation);
            Destroy(gameObject, delete);
        }
        else
        {
            Instantiate(Train[1], transform.position, transform.rotation);
            Destroy(gameObject, delete);
        }
    }
}
