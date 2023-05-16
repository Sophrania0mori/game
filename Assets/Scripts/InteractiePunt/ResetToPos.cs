using UnityEngine;

public class ResetToPos : MonoBehaviour
{
    [SerializeField] private GameObject InteractionBox;
    [SerializeField] private GameObject objectToMove;
    [SerializeField] private float moveDuration = 1.0f;

    private bool isMoving = false;
    private float startTime;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = objectToMove.transform.position;
    }

    public void OnButtonClick()
    {
        if (!isMoving)
        {
            isMoving = true;
            startTime = Time.time;
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            float t = (Time.time - startTime) / moveDuration;
            objectToMove.transform.position = Vector3.Lerp(startPosition, startPosition, t);
            if (t >= 1.0f)
            {
                isMoving = false;
                InteractionBox.gameObject.SetActive(false);
            }
        }
    }
}