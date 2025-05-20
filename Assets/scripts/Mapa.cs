using UnityEngine;

public class MinimapRotation : MonoBehaviour
{
    public RectTransform targetImage;
    public float rotationSpeed = 100f;

    private bool rotatingLeft = false;
    private bool rotatingRight = false;

    void Update()
    {
        if (rotatingLeft)
            targetImage.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        else if (rotatingRight)
            targetImage.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    // Llamados por botones UI
    public void StartRotateLeft()
    {
        rotatingLeft = true;
    }

    public void StopRotateLeft()
    {
        rotatingLeft = false;
    }

    public void StartRotateRight()
    {
        rotatingRight = true;
    }

    public void StopRotateRight()
    {
        rotatingRight = false;
    }
}
