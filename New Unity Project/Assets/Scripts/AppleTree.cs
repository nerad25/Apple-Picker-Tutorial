using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which apple tree moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that the AppleTree will change directrions
    public float chanceToChangeDirections = 0.1f;

    // Rate at which Apples will be instaitiated
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Dropping apples every second
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke( "DropApple", secondsBetweenAppleDrops );
    }

    // Update is called once per frame
    void Update()
    {
        //Basic movement

        // Gets current position and stores position in pos
        Vector3 pos = transform.position;

        //Time.delta time is the measure of the number of seconds since last frame
        pos.x += speed * Time.deltaTime;

        // assigns modified pos back to transform. Which moves the AppleTree
        transform.position = pos;

        //Changing direction

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);                              // Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);                           // Move left
        }
    }

    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)     //Random returns a value between 0 and 1, if its less than chance...then change directions (speed set to neg val)
        {
            speed *= -1;
        }
    }
}