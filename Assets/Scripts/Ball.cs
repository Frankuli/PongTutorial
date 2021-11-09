using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 7;

    private Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Launch();
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
        Launch();
    }

    public void Launch()
    {
        float x = (Random.Range(0, 2) == 0 ? -1 : 1);
        float y = (Random.Range(0, 2) == 0 ? -1 : 1);

        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
