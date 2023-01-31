using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour
{
    public Vector3 Direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move the meteor in the direction specified each frame
        transform.position = transform.position + Direction * Time.deltaTime;

        //If the meteor goes of screen on the left move it to off screen on the right
        //also giving it a random Y value
        if (transform.position.x < -11f)
        {
            transform.position = new Vector3(11f, Random.Range(-4.0f, 4.0f), 0.0f);
        }
    }
}
