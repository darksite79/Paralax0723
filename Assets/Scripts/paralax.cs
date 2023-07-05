using UnityEngine;

public class paralax : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 previousCameraPosition;
    public float paralaxDelay = 0.0f;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = (cameraTransform.position.x - previousCameraPosition.x)*paralaxDelay;
        transform.Translate(new Vector3(deltaX, 0, 0));
        previousCameraPosition = cameraTransform.position;
    }
}
