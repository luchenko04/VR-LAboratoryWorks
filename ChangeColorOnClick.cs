using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        if (objectRenderer != null)
        {
            objectRenderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

}
