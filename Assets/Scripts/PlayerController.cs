using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // attach the rigid body to the object

    }

    // Update is called once per frame
    void Update()
    {
        //when space is pressed the player jump up
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * 10,ForceMode.Impulse);
        }
    }
}
