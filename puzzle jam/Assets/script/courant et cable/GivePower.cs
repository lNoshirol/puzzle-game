using HPhysic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePower : MonoBehaviour
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

        /*if (connectorList[0].GetComponent<Connector>().ConnectedTo != null)
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
        }*/

        





        foreach (GameObject connector in connectorList)
        {

            if (REPARE(connector))
            {
                gameObject.GetComponent<Powered>().isPowered = false;
                break;
            }
            else
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
                gameObject.GetComponent<Powered>().isPowered = false;

            }



            
        }
    }

    public bool REPARE(GameObject TROUVE)
    {
        if (nsmFlaqueOuPasFlaque)
        {
            foreach (GameObject boutDeCable in FindAnyObjectByType<colliderDetector>().listOfWhatCollidWithFlaque)
            {
                if (TROUVE == boutDeCable)
                {
                    return true;
                }
            }
            return false;
        }
        else
        {
            return false;
        }

    }

}


/*Debug.Log(gameObject.name + " connector type : " + connector.name + " name of connected oject : " + connector.GetComponent<Connector>().ConnectedTo.name + " is the connected object powered : " + connector.GetComponent<Connector>().ConnectedTo.gameObject.GetComponent<Powered>().isPowered);
                gameObject.GetComponent<Powered>().isPowered = true;
                break;*/