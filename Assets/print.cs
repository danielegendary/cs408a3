using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class print : MonoBehaviour
{
    private GameObject ob1;
    
    void Awake()
    {
        // Create three cubes and place them close to the world space center.
        ob1 = GameObject.Find("object 1");
    }
    
    void Update()
    {  
       print("position: "+ transform.position+ "rotation: "+transform.rotation + "keyframe: "+Time.time);
    }

}
