using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpeedPopulator : MonoBehaviour
{
    Vector3 lastPosition = Vector3.zero;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = (transform.position - lastPosition).magnitude;
        lastPosition = transform.position;
    }
}
