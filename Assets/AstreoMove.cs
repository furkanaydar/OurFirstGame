using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreoMove : MonoBehaviour
{

    private Rigidbody2D rb;
    private float jumpForce = 40f;
    public bool engineIsOn;
    // Start is called before the first frame update
    void Start()
    {
        engineIsOn = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            engineIsOn = true;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            engineIsOn = false;
        }
        /*
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            engineIsOn = true;

        }

         if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            engineIsOn = false;
            
        }*/
        
    }

    private void FixedUpdate()
    {

        switch (engineIsOn)
        {
            case true:
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
                break;
            case false:
                rb.AddForce(new Vector2(0f, 0f), ForceMode2D.Force);
                break;
        }

    }
}
