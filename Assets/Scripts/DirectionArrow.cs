using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public GameObject arrow;
    public Transform target;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            arrow.SetActive(!arrow.activeSelf);
            if (arrow.activeSelf)
            {
                UpdateArrowRotation();
            }
        }
    }

    private void LateUpdate()
    {
        if (arrow.activeSelf)
        {
            UpdateArrowRotation();
        }
    }

    private void UpdateArrowRotation()
    {
        Vector3 direction = (target.position - arrow.transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        arrow.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}