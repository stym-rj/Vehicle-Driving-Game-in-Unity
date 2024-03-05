using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    private float turnSpeed = 50;
    private float horizontalInput;
    private float forwardInput;
    public TextMeshPro winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Comment
        // transform.Translate(0, 0, 1 * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        // to win
        /*if (transform.position.z > 50)
        {
            Win();
        }*/
    }

    void Win()
    {
        winText.GetComponent<Renderer>().enabled = true;
        winText.text = "You Win!!";
    }
}
