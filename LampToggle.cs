using UnityEngine;

public class LampToggle : MonoBehaviour
{
    private Material lampMaterial;
    private bool isEmitting = true;

    private void Start()
    {
        lampMaterial = GetComponent<Renderer>().material;
    }

    private void OnMouseDown()
    {
        isEmitting = !isEmitting;

        if (isEmitting)
        {
            lampMaterial.EnableKeyword("_EMISSION");
        }
        else
        {
            lampMaterial.DisableKeyword("_EMISSION");
        }
    }
}
