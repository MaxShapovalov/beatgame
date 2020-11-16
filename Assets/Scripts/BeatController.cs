using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatController : MonoBehaviour
{
    
    public GameObject roundNeedle;
    public GameObject roundGuy;
    bool paused = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pause()
    {
        if (paused)
        {
            paused = false;
            Time.timeScale = 1;
            print("paused");
            return;
        }

        if (!paused)
        {
            paused = true;
            Time.timeScale = 0;
            print("playing");
            return;
        }
    }
}
