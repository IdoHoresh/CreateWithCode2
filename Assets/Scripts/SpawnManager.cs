using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject spawnObstacle;
    public float repeatRate = 5f;
    public float startDelay = 0;
    private PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        if(playerController.gameOver == false)
        {
        Instantiate(spawnObstacle, transform.position, spawnObstacle.transform.rotation);
        }
    }
}
