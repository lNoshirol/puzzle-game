using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listCableConnected : MonoBehaviour
{
    public List<GameObject> listOfConnectedCable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var cable in listOfConnectedCable)
        {
            if (GetComponent<Powered>().isPowered)
            {
                cable.GetComponent<Powered>().isPowered = true;
            }
        }
    }
}
