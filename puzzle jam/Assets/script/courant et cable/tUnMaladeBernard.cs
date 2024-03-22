using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tUnMaladeBernard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Powered>().isPowered)
        {
            FindAnyObjectByType<PORTEMOVE>().gameObject.GetComponent<PORTEMOVE>().MONTEOUDESCEND = 1;
        }
        else
        {
            FindAnyObjectByType<PORTEMOVE>().gameObject.GetComponent<PORTEMOVE>().MONTEOUDESCEND = -1;
        }
    }
}
