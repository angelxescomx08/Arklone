using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    float bounds = 5.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float newXPosition = speed * xInput * Time.deltaTime + transform.position.x;
        if(newXPosition > -bounds && newXPosition < bounds)
        {
            transform.position += new Vector3(speed * xInput * Time.deltaTime, 0f, 0f);
        }
    }
}
