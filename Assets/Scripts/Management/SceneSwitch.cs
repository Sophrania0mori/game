using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public Transform PlayerCharacter;

    private void Update()
    {
        if (PlayerCharacter.position.x > -0.2 && PlayerCharacter.position.x < 0 && PlayerCharacter.position.y > 0.3 && PlayerCharacter.position.y < 0.6)
        {
            SceneManager.LoadScene(2);
        }

        if (PlayerCharacter.position.x > -2.4 && PlayerCharacter.position.x < -2.2 && PlayerCharacter.position.y > -2.1 && PlayerCharacter.position.y < -1.9)
        {
            if (PlayerPrefs.HasKey("Level1Complete"))
            {
                if (PlayerPrefs.GetInt("Level1Complete") == 1)
                {
                    SceneManager.LoadScene(3);
                }
            }
            else
            {
                Debug.Log("Player is trying to enter level 2, but level 1 was not completed.");
            }
        }
    }
}