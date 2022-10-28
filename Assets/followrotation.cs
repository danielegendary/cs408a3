using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class followrotation : MonoBehaviour
{   
    public PathCreator PathCreator;
    public float speed = 5; //set deflaut speed
    float distanceTravelled; //creat fload to track the curve
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = PathCreator.path.GetPointAtDistance(distanceTravelled); //follow the path by changing the position value
        transform.rotation = PathCreator.path.GetRotationAtDistance(distanceTravelled);// make rotation by changing the rotation value with curve
    }
}
