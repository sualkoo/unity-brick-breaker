using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private Vector3 platformSize;
    public float speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
    }
    void Update()
    {
        var ball = GameObject.Find("Ball");
        if (Input.GetKey(KeyCode.Space) && ball.GetComponent<BallBehaviour>().isSteady())
        {
            ball.GetComponent<BallBehaviour>().MoveZourAss();
        }
    }
    void FixedUpdate()
    {
        //rb.MovePosition(new Vector2(Mathf.Clamp(rb.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime, -screenBounds.x + 1.25f, screenBounds.x - 1.25f), rb.position.y));
        rb.MovePosition(new Vector2(Mathf.Clamp(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, -screenBounds.x + 1.25f, screenBounds.x - 1.25f), rb.position.y));
    }

    public void Downscale(float downscaleX)
    {
        gameObject.transform.localScale -= new Vector3(downscaleX,0,0);
    }
}
