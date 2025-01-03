using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveLeft : MonoBehaviour
{
    private Vector3 leftDirection = Vector3.left;
    public float obstacleSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(leftDirection * Time.deltaTime * obstacleSpeed);
    }
}
