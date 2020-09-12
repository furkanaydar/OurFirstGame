using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Rigidbody2D rigidBody;

    private float width;

    private float speed = -3f;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rigidBody = GetComponent<Rigidbody2D>();

        width = boxCollider.size.y;
        rigidBody.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-width){
            Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 vector = new Vector2(0, width*2f);
        transform.position = (Vector2) transform.position + vector;
    }
}
