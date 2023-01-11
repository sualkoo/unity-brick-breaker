using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction = new Vector3(0,0,0);
    private Vector2 screenBounds;
    public float speed = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
    }
    private void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;
        if(gameObject.transform.position.y < -5)
        {
            gameObject.transform.position = new Vector3(0,0,0);
            rb.velocity = new Vector3(0,0,0);
        }

    }

    public void MoveZourAss() {
        direction = new Vector2(Random.Range(-1f,1f),Random.Range(-1f,1f)).normalized;
        rb.AddForce(direction * speed, ForceMode2D.Impulse);

    }

    public bool isSteady()
    {
        return rb.velocity.Equals(new Vector3(0,0,0));
    }
}
