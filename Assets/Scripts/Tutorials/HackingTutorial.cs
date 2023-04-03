using UnityEngine;

public class HackingTutorial : MonoBehaviour
{
    [SerializeField] private GameObject HackingPopUp;
    [SerializeField] private GameObject NextTutorial;
    [SerializeField] private GameObject Door;

    private void Update()
    {
        if (Door.transform.position.y == 2)
        {
            HackingPopUp.gameObject.SetActive(false);
            NextTutorial.gameObject.SetActive(true);
            enabled = false;
        }
    }
}