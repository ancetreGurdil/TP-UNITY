using UnityEngine;

public class birdBehaviour : MonoBehaviour
{
    public float flyForce = 80;
    public float speedX = 1.5f;
    public  bool collide;

    private  Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector2(speedX,_rb.velocity.y);
        if(Input.GetKey(KeyCode.Space)){
            _rb.AddForce(new Vector2(0,flyForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "object")
        {
            collide = true;
        }
    }
}
