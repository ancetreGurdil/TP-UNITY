using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform birdTransform; 
    public float smoothSpeed;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (birdTransform != null)
        {
            Vector3 desiredPosition = new Vector3(birdTransform.position.x + offset.x, transform.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
   
}
