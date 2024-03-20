using HPhysic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivePower : MonoBehaviour
{
    public List<GameObject> connectorList;
    private void Start()
    {
        connectorList.Add(GameObject.Find("TAMERE"));
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject connector in connectorList)
        {
            Debug.Log(gameObject.name + " " + connector);
            if (connector.GetComponent<Connector>().ConnectedTo != null && connector.GetComponent<Connector>().ConnectedTo.gameObject.GetComponent<Powered>().isPowered)
            {
                Debug.Log(gameObject.name + " name of connected oject : " + connector.GetComponent<Connector>().ConnectedTo.name + " is the connected object powered : " + connector.GetComponent<Connector>().ConnectedTo.gameObject.GetComponent<Powered>().isPowered);
                gameObject.GetComponent<Powered>().isPowered = true;
                break;
            }
            gameObject.GetComponent<Powered>().isPowered = false;
        }
    }

}
