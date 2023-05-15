using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private float detectionDistance = 5f;
    [SerializeField] private GameObject player;
    private bool Checkpoint1 = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance <= detectionDistance)
        {
            PlayerPrefs.SetInt("Checkpoint1", 1);
        }

        if (PlayerPrefs.HasKey("Checkpoint1"))
        {
            Checkpoint1 = PlayerPrefs.GetInt("Checkpoint1") == 1 ? true : false;
        }

        if (Checkpoint1)
        {
            enabled = false;
        }
    }
}
