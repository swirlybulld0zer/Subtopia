using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public float pitch;
    public GameObject Player;
    public float movespeed;
    public Vector3 offset;
    private Vector3 velocity = Vector3.one;
   
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("King");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 King = Vector3.SmoothDamp(transform.position, Player.transform.position - offset, ref velocity,  movespeed * Time.deltaTime);
        transform.position = King;
        
    }


   
}
