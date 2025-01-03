using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos; 
    private float repeatWidth;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; //the background will start from the starting position

        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // we calcualte just the middle of the background to make the transition smooth
    }

    // Update is called once per frame
    void Update()
    {
        //if the current position is far away from the start by 50 we restart the startPosition
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
