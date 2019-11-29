using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    protected Vector2 velocity;
    public float gravity = 0.2f;
    protected Rigidbody2D rb;
    protected const float minMoveDist = 0.001f;
    protected ContactFilter2D contactFilter;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        contactFilter.useTriggers = false;
        contactFilter.SetLayerMask(Physics2D.GetLayerCollisionMask(gameObject.layer));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        velocity += gravity * Physics2D.gravity * Time.deltaTime;

        Vector2 deltaPosition = velocity * Time.deltaTime;

        Vector2 move = Vector2.up * deltaPosition.y;

        Movement(move);

    }

    void Movement(Vector2 move)
    {
        float distance = move.magnitude;
        if (distance > minMoveDist)
        {

        }
        rb.position = rb.position + move;
    }
}
