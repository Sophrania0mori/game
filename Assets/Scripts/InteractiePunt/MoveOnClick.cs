using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    [SerializeField] private GameObject InteractionBox;
    [SerializeField] private GameObject objectToMove;
    [SerializeField] private float moveDuration = 1.0f;
    [SerializeField] private float moveDistance = 5.0f;
    [SerializeField] private float minYCoordinate = -Mathf.Infinity;

    private bool isMoving = false;
    private float startTime;
    private Vector3 startPosition;

    public void OnButtonClick()
    {
        if (!isMoving && objectToMove.transform.position.y >= minYCoordinate)
        {
            isMoving = true;
            startTime = Time.time;
            startPosition = objectToMove.transform.position;
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            float t = (Time.time - startTime) / moveDuration;
            objectToMove.transform.position = Vector3.Lerp(startPosition, startPosition + new Vector3(0, moveDistance, 0), t);
            if (t >= 1.0f)
            {
                isMoving = false;
                InteractionBox.gameObject.SetActive(false);
            }
        }
    }
}