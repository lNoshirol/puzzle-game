using HPhysic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePower : MonoBehaviour
{
    public List<GameObject> connectorList;
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject connector in connectorList)
        {
            if (connector.GetComponent<Connector>().ConnectedTo != null && connector.GetComponent<Connector>().ConnectedTo.gameObject.GetComponentInParent<Powered>().isPowered)
            {
                if (connector.tag == "boutDeCable")
                {
                    if (connector.GetComponent<Connector>().ConnectedTo.gameObject.GetComponentInParent<Powered>().isPowered)
                    {
                        gameObject.GetComponent<Powered>().isPowered = true;
                        break;
                    }
                }
                else if (connector.tag == "prise")
                {
                    if (connector.GetComponent<Connector>().ConnectedTo.gameObject.GetComponent<Powered>().isPowered)
                    {
                        gameObject.GetComponent<Powered>().isPowered = true;
                        break;
                    }
                }
            }

            if (!GetComponentInParent<Powered>().isPowered)
            {
                
            }
            gameObject.GetComponent<Powered>().isPowered = false;
        }
    }

}


/*Debug.Log(gameObject.name + " connector type : " + connector.name + " name of connected oject : " + connector.GetComponent<Connector>().ConnectedTo.name + " is the connected object powered : " + connector.GetComponent<Connector>().ConnectedTo.gameObject.GetComponent<Powered>().isPowered);
                gameObject.GetComponent<Powered>().isPowered = true;
                break;*/