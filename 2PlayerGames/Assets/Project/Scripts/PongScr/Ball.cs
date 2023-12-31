using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D BallRb;
    [SerializeField] public float BallSpeed = 5;
    private Vector2 direction;

    private void Start()
    {
        SetTheDirection();
    }
    private void FixedUpdate()
    {
        StartCoroutine(BallMove());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            direction.x = -direction.x;
        else if (other.gameObject.CompareTag("Wall"))
            direction.y = -direction.y;
    }

    public void SetTheDirection()
    {
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
    }
    public IEnumerator BallMove()
    {
        yield return new WaitForSeconds(3);
        BallRb.velocity = direction.normalized * BallSpeed;
    }
}
