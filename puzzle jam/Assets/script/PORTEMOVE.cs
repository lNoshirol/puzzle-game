using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PORTEMOVE : MonoBehaviour
{
    public int MONTEOUDESCEND;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            //Debug.Log("TA MERE 1");
            MONTEOUDESCEND = 0;
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        else if (transform.position.y > 5)
        {
            //Debug.Log("TA MERE 2");
            MONTEOUDESCEND = 0;
            transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }
        else if (transform.position.y >= 0 && transform.position.y <= 5)
        {
            //Debug.Log("TA MERE 3");
            transform.position += new Vector3(0, MONTEOUDESCEND, 0) * Time.deltaTime * 2;
        }
    }
}
