using System.Threading;
using UnityEngine;

public class PointCountedBehaviour : MonoBehaviour
{
    private float totalTimeInSeconds = 0.6f;
    private float currentTimeInSeconds;
    public GameManager gameManager;
    public float raycastDistance;
    public LayerMask hitLayers;
    private RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        currentTimeInSeconds = totalTimeInSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimeInSeconds > 0 && gameManager.score != 0)
        {
            currentTimeInSeconds -= Time.deltaTime;
        } else {
            hit = Physics2D.Raycast(transform.position,Vector2.down,raycastDistance,hitLayers);
            if (hit != false)
            {
                gameManager.score += 1;
            }
            currentTimeInSeconds = totalTimeInSeconds;
        }
    }

}
