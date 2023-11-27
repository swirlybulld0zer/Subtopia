using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testMove : MonoBehaviour
{
    public float MoveSpeed;
    public TMP_Text Level;
    public Rigidbody2D rb;
    float TurnSpeed;
    public Animator FishMator;
    public float Movex;
    public SpriteRenderer Fishenderer;
    public GameObject Surface;
    float surfaceLevel;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Surface = GameObject.FindGameObjectWithTag("Surface");
       
    }

    // Update is called once per frame
    void Update()
    {
        
        float surfaceLevel = Mathf.Ceil(Mathf.Abs(gameObject.transform.position.y - Surface.transform.position.y));
        Level.text = "SurfaceLevel:" + surfaceLevel.ToString();

        Movex = Input.GetAxis("Horizontal");
       float Movey = Input.GetAxis("Vertical");

        Vector3 Movedir = new Vector3(Movex, Movey, 0);

        transform.Translate(Movedir * MoveSpeed * Time.deltaTime);

        Movedir.Normalize();
       
        Vector3 MoveRotate = Movedir;

        if (Movedir != Vector3.zero)
        {
            Quaternion toRotate = Quaternion.Euler(0, 0, -90) * Quaternion.LookRotation(forward: Vector3.forward, upwards: Movedir);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, TurnSpeed * Time.deltaTime);

            //float angle = Mathf.Atan2(-moveDirection.y, -moveDirection.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward * Time.deltaTime);
        }
        //Animation();
       if(Movex > 0)
        {
            Fishenderer.flipX = false;
        }
        if (Movex < 0)
        {
            Fishenderer.flipX = true;
        }
    }
   
    //void Animation()
    //{
    //    FishMator.SetFloat("fishspeed", rb.velocity.sqrMagnitude);
    //}

   
}
