using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHomeTown : MonoBehaviour
{
        public static bool isGamePaused;

    // Start is called before the first frame update
    void Start()
    {
        // When scene is loaded, set the time scale to 1
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
