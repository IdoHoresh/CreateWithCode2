using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    public float xRange = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xRange)
        {
            Destroy(gameObject);
        }
    }
}
