using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsBehaviour : MonoBehaviour
{
    private EdgeCollider2D ec;
    void Start()
    {
        ec = GetComponent<EdgeCollider2D>();
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        Vector2[] points = new Vector2[4];
        points[0] = -screenBounds;
        points[1] = new Vector2(-screenBounds.x, screenBounds.y);
        points[2] = screenBounds;
        points[3] = new Vector2(screenBounds.x, -screenBounds.y);

        ec.points = points;
    }
}
