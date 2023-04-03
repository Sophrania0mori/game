using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolgendeLevelHuisje : MonoBehaviour
{
    public Transform PlayerCharacter;

    private void Update()
    {
        if (PlayerCharacter.position.x > -0.2 && PlayerCharacter.position.x < 0 && PlayerCharacter.position.y > 0.3 && PlayerCharacter.position.y < 0.6)
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}