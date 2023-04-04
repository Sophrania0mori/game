using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Proximity : MonoBehaviour
{
    [SerializeField] private GameObject PlayerCharacter;
    [SerializeField] private GameObject TargetObject;
    [SerializeField] private float activationDistance = 5f;
    [SerializeField] private bool isActive = false;
    [SerializeField] private GameObject InteractionBox;

    private void Update()
    {
        if (!isActive && Vector3.Distance(TargetObject.transform.position, PlayerCharacter.transform.position) <= activationDistance)
        {
            TargetObject.gameObject.SetActive(true);
            isActive = true;
        }
        else if (isActive && Vector3.Distance(TargetObject.transform.position, PlayerCharacter.transform.position) > activationDistance)
        {
            InteractionBox.gameObject.SetActive(false);
            TargetObject.gameObject.SetActive(false);
            isActive = false;
        }

        if (isActive && Input.GetKeyDown(KeyCode.E))
        {
            InteractionBox.gameObject.SetActive(true);
        }
    }
}