using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    void Start()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}