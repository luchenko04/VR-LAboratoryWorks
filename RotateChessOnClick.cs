using UnityEngine;

public class RotateChessOnClick : MonoBehaviour
{
    public float rotationAngle = 45f;
    private float currentRotation = 0f;

    private void OnMouseDown()
    {
        currentRotation += rotationAngle;
        transform.rotation = Quaternion.Euler(0, currentRotation, 0);
    }
}
