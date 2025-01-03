using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
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
        //when space is pressed the player jump up
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
        }
    }
}
