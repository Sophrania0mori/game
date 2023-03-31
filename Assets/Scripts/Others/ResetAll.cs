using UnityEngine;

public class ResetAll : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0) && Input.GetKey(KeyCode.Keypad3) && Input.GetKey(KeyCode.Keypad5))
        {
            Debug.Log("Reset all!");
            PlayerPrefs.SetInt("WalkTutorial", 0);
            PlayerPrefs.SetInt("JumpTutorial", 0);
            PlayerPrefs.SetInt("EnemyTutorial", 0);
        }
    }
}