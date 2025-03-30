using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Vector2 force;
    bool isBallLaunched = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Launch") && !isBallLaunched)
        {
            rb.AddForce(force);
            transform.parent = null;
            isBallLaunched = true;
        }
    }
}
