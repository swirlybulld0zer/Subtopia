using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallEnter : MonoBehaviour
{
    public GameObject Enter;
    public GameObject Exit;
    public TriggerEnter ent;
    public TriggerExit ext;
    public GameObject king;
    public GameObject EnterText;
    public GameObject ExitText;
    // Start is called before the first frame update
    void Start()
    {
        Enter = GameObject.FindGameObjectWithTag("Enter");
        Exit = GameObject.FindGameObjectWithTag("Exit");
        king = GameObject.FindGameObjectWithTag("King");
    }

    // Update is called once per frame
    void Update()
    {
        if(ext.exited == true)
        {
            EnterText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                king.transform.position = Enter.transform.position;
                Debug.Log("E!!!");
            }
        }
        else
        {
            EnterText.SetActive(false);
        }
        if(ent.Entered == true)
        {
            ExitText.SetActive(true);
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                king.transform.position = Exit.transform.position;
                Debug.Log("E!!!");
            }
        }
        else{
            ExitText.SetActive(false); 
        }
    }
}
