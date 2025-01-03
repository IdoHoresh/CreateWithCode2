using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.up * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
