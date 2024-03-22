using HPhysic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePower2 : MonoBehaviour
{
    public List<GameObject> connectorList;
    public bool isConnectedToPowerSource;
    public bool nsmFlaqueOuPasFlaque;
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (connectorList[0].GetComponent<Connector>().ConnectedTo != null)
        {
            if (GetComponent<Powered>().isPowered || connectorList[0].GetComponent<Connector>().ConnectedTo.GetComponentInParent<Powered>().isPowered)
            {
                GetComponent<Powered>().isPowered = true;
            }
        }
        else if (connectorList[1].GetComponent<Connector>().ConnectedTo != null)
        {
            if (GetComponent<Powered>().isPowered || connectorList[1].GetComponent<Connector>().ConnectedTo.GetComponentInParent<Powered>().isPowered)
            {
                GetComponent<Powered>().isPowered = true;
            }
        }
        else
        {
            GetComponent<Powered>().isPowered = false;
        }
    }
}