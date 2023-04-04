using UnityEngine;

public class InteractTutorial : MonoBehaviour
{
    [SerializeField] private GameObject InteractPopUp;
    [SerializeField] private GameObject NextTutorial;
    [SerializeField] private GameObject InteractionBox;

    private void Update()
    {
        if (InteractionBox.activeSelf)
        {
            InteractPopUp.gameObject.SetActive(false);
            NextTutorial.gameObject.SetActive(true);
            enabled = false;
        }
    }
}