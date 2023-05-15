using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}