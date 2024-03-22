using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powered : MonoBehaviour
{
    public bool isPowered = false;
    public bool isPowerSource = false;
    public bool isConnectToSource = false;

    private void Update()
    {

        if (isPowerSource)
        {
            isPowered = true;
        }

    }
}
