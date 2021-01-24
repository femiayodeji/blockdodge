using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public BoxCollider boxCollider;
    public GameManager gameManager;
    public Rigidbody rBody;
    public float moveSpeed = 7f;
    
    private Vector3 movement;    

    void Update()
    {
        movement.z = Input.GetAxisRaw("Horizontal");        
    }

    void FixedUpdate()
    {
        rBody.MovePosition(rBody.position + movement * Time.fixedDeltaTime * moveSpeed);
    }

    void OnTriggerEnter(Collider collider)
    {
        if((collider.tag == "Obstacle"))
        {
            // boxCollider.enabled = true;
            gameManager.GameOver();
        }
    }
}
