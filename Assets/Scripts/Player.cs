using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10.0f;
    public Rigidbody2D PhysicsRigidbody;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input_x = Input.GetAxis("Horizontal");
        Vector2 Velocity = new Vector2(Speed * input_x, PhysicsRigidbody.velocity.y);
        PhysicsRigidbody.velocity = Velocity;
    }
}
