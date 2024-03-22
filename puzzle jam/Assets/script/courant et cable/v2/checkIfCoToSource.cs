using HPhysic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkIfCoToSource : MonoBehaviour
{
    

    void Update()
    {
        if (GetComponent<Connector>() == null)
        {
            GetComponentInParent<Powered>().isConnectToSource = false;
        }
        else if (GetComponent<Connector>().ConnectedTo.GetComponent<Powered>().isPowerSource)
        {
            GetComponentInParent<Powered>().isConnectToSource = true;
        }
    }
}
