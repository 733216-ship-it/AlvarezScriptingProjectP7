using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This line is here to tell me the x position of the object in  the scene
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //this line is here to tell me the y position of the object in the scene
        if (transform.position.y <= 5f)
        {
            Debug.Log("Im about to hit the ground!");
        }
    }
}
