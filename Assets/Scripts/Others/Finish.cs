using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private Transform PlayerCharacter;
    [SerializeField] private float FinishPosition;

    private void Update()
    {
        if (PlayerCharacter.position.x > FinishPosition)
        {
            SceneManager.LoadScene(sceneBuildIndex:1);
        }
    }
}
