using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{
    public bool exited;

    // Start is called before the first frame update
    void Start()
    {
        exited = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "King")
        {
            exited = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "King")
        {
            exited = false;
        }
    }
}
