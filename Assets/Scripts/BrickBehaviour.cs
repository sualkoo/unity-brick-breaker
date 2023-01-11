using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D col)
    {
        col.gameObject.GetComponent<BallBehaviour>().speed *= 1.1f;
        GameObject.Find("Platform").GetComponent<PlatformBehaviour>().Downscale(0.2f);

        Destroy(this.gameObject);
    }
}
