using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayyerController : MonoBehaviour
{
    Rigidbody rb;
    public float jumpforce;
    bool canjump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {



        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canjump )
        {
            //jump
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Ground")
        {
            canjump = true;
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canjump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("Game");
        }
    }


}
