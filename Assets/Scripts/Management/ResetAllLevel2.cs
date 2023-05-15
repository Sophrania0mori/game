

using UnityEngine;

public class ResetAllLevel2 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0) && Input.GetKey(KeyCode.Keypad3) && Input.GetKey(KeyCode.Keypad5))
        {
            Debug.Log("Reset all!");
            PlayerPrefs.SetInt("Checkpoint1", 0);
        }
    }
}
