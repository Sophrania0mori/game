using UnityEngine;

public class ConfirmBoxEnable : MonoBehaviour
{
    [SerializeField] private GameObject ConfirmationBox;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            ConfirmationBox.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}