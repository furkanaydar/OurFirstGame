using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followAstreo : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;
    public float minimum = -1F;
    public float maximum =  1F;
    static float t = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 addition = new Vector3(0, Mathf.Lerp(minimum, maximum, t), 0);
        t += 0.5f * Time.deltaTime;
        if (t > 2f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
        transform.position = new Vector3(transform.position.x,
        //Mathf.Clamp(targetToFollow.position.y, 0f, 10f), bu sınırlı bg da geçerli
        targetToFollow.position.y,
        transform.position.z) + addition ;

    }
}
