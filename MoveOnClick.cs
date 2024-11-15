using UnityEngine;
using System.Collections;

public class MoveChairOnClick : MonoBehaviour
{
    public float moveDistance = 0.1f;
    public float moveSpeed = 2.0f;

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool isMoving = false;
    private bool movedBack = false;

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + transform.forward * moveDistance;
    }

    private void OnMouseDown()
    {
        if (!isMoving)
        {
            StartCoroutine(MoveChair());
        }
    }

    private IEnumerator MoveChair()
    {
        isMoving = true;
        Vector3 destination = movedBack ? initialPosition : targetPosition;

        while (Vector3.Distance(transform.position, destination) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = destination;
        movedBack = !movedBack;
        isMoving = false;
    }
}
