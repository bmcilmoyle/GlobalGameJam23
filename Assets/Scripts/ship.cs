using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0.0f, 2.0f, 0.0f) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0.0f, -2.0f, 0.0f) * Time.deltaTime;
        }
    }


    //If the collider is set to "trigger" and has a rigidbody this method will be called on collisions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Reset Scene");

        SceneManager.LoadScene(0);
    }
}
