using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D ballRb;
    [SerializeField] private float initialVelocity = 4f;
    [SerializeField] private float velocityMultiplier = 1.1f;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Lauch();
    }
    private void Lauch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Paggle"))
        {
            ballRb.velocity *= velocityMultiplier;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
