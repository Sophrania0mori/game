using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] private float attackDistance = 2f;
    [SerializeField] private GameObject player;

    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < attackDistance)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}