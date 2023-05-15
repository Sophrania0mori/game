using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private float detectionDistance = 5f;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject checkpointFlag;
    private bool Checkpoint1 = false;
    private Renderer flagRenderer;

    private void Start()
    {
        flagRenderer = checkpointFlag.GetComponent<Renderer>();
        flagRenderer.material.color = Color.black;
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance <= detectionDistance)
        {
            flagRenderer.material.color = Color.white;
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
