using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isOnGround = true;
    public float jumpForce = 10;
    public float gravityModifier;
    private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // attach the rigid body to the object
        Physics.gravity*=gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        
        //when space is pressed the player jump up only if the player is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }

    private void OnCollisionEnter(Collision collision) // if the player collide with any thing (the floor) the bool will be set to true to be able to jump again
    {
        isOnGround = true;
    }
}
