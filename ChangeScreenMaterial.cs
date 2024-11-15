using UnityEngine;

public class ChangeScreenMaterial : MonoBehaviour
{
    public Material[] materials;
    private int currentIndex = 0;
    private Renderer screenRenderer;

    public GameObject screenObject;

    private void Start()
    {
        if (screenObject != null)
        {
            screenRenderer = screenObject.GetComponent<Renderer>();
        }
    }

    private void OnMouseDown()
    {
        if (screenRenderer != null && materials.Length > 0)
        {
            currentIndex = (currentIndex + 1) % materials.Length;
            screenRenderer.material = materials[currentIndex];
        }
    }
}

