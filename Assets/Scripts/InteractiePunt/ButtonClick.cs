using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Transform Door;
    public float MoveSpeed = 1.0f;
    public GameObject InteractionBox;
    public GameObject ButtonsToEnable;

    private Vector3 targetPosition;

    void Start()
    {
        // Attach listeners to the buttons' onClick events
        Button1.onClick.AddListener(MoveDoorUp);
        Button2.onClick.AddListener(MoveDoorLeft);
        Button3.onClick.AddListener(MoveDoorRight);

        targetPosition = Door.position;
    }

    void MoveDoorUp()
    {
        targetPosition = Door.position + Vector3.up * 5f;
        InteractionBox.gameObject.SetActive(false);
        ButtonsToEnable.gameObject.SetActive(false);
    }

    void MoveDoorLeft()
    {
        targetPosition = Door.position + Vector3.left * 5f;
        InteractionBox.gameObject.SetActive(false);
        ButtonsToEnable.gameObject.SetActive(false);
    }

    void MoveDoorRight()
    {
        targetPosition = Door.position + Vector3.right * 5f;
        InteractionBox.gameObject.SetActive(false);
        ButtonsToEnable.gameObject.SetActive(false);
    }

    void Update()
    {
        float step = MoveSpeed * Time.deltaTime;
        Door.position = Vector3.MoveTowards(Door.position, targetPosition, step);
    }
}