using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro winText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.z > 75)
        {
            Win();
        }
    }

    void Win()
    {
        winText.GetComponent<Renderer>().enabled = true;
        winText.text = "You Win!!";
    }
}
