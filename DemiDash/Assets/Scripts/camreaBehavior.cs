using UnityEngine;

public class camreaBehavior : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float cameraSpeed = 5f;
    [SerializeField] private float yThreshold = 5f;

    private float originalYPosition;

    private void Start()
    {
        originalYPosition = transform.position.y;
    }

    private void Update()
    {
        // Move the camera to the right at a constant speed
        transform.Translate(cameraSpeed * Time.deltaTime, 0, 0);


    }
}
