using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private float detectionDistance = 5f;
    [SerializeField] private GameObject player;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance <= detectionDistance)
        {
            PlayerPrefs.SetInt("Checkpoint1", 1);
        }
    }
}
