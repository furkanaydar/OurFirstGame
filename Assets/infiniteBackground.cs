using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteBackground : MonoBehaviour
{

    [SerializeField]
    private Transform centerBackground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= centerBackground.position.y + 32f)
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y + 32f);

        else if(transform.position.y <= centerBackground.position.y - 32f)
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y - 32f);
    }
}
