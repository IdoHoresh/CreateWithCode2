using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveLeft : MonoBehaviour
{
    private Vector3 leftDirection = Vector3.left;
    public float obstacleSpeed = 10f;
    private PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>(); // find the player and get his PlayerController component
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver == false)
        {
            transform.Translate(leftDirection * Time.deltaTime * obstacleSpeed);
        }
        
    }
}
