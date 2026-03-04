using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject target;

    public void Toggle()
    {
        target.SetActive(!target.activeSelf);
    }
}
