using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnObstacle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(spawnObstacle, transform.position, spawnObstacle.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
