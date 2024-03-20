using HPhysic;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GivePowerForPrise : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Powered>().isPowered = false;

        if (GetComponent<Connector>().ConnectedTo != null)
        {
            if (GetComponent<Connector>().ConnectedTo.GetComponentInParent<Powered>().isPowered)
            {
                GetComponent<Powered>().isPowered = true;
            }
            
        }
    }
}
