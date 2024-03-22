using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transferCourantBetweenTwoPrise : MonoBehaviour
{
    public GameObject priseOne;
    public GameObject priseTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (priseOne != null && priseTwo != null)
        {
            if (priseOne.GetComponent<Powered>().isPowered || priseTwo.GetComponent<Powered>().isPowered)
            {
                priseOne.GetComponent<Powered>().isPowerSource = true;
                priseTwo.GetComponent<Powered>().isPowerSource = true;
            }
        }
    }
}
