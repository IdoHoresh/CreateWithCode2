using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject spawnObstacle;
    public float repeatRate = 5f;
    public float startDelay = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        Instantiate(spawnObstacle, transform.position, spawnObstacle.transform.rotation);
    }
}
