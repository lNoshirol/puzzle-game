using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class colliderDetector : MonoBehaviour
{
    public List<GameObject> listOfWhatCollidWithFlaque;

    private void Update()
    {
        if (GetComponent<Powered>().isPowered)
        {
            ApplyPowerForOtherObject(true);
        }
        else
        {
            ApplyPowerForOtherObject(false);
        }
        CheckIfPoweredCableTouchTheWater();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cable"|| collision.gameObject.tag == "boutDeCable")
        {
            listOfWhatCollidWithFlaque.Add(collision.gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        listOfWhatCollidWithFlaque.Remove(collision.gameObject);
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    public void CheckIfPoweredCableTouchTheWater()
    {
        foreach (GameObject obj in listOfWhatCollidWithFlaque)
        {
            if (obj.GetComponentInParent<Powered>().isPowered)
            {
                GetComponent<Powered>().isPowered = true;
                break;
            }
            else
            {
                GetComponent<Powered>().isPowered = false;
            }
        }
    }

    public void ApplyPowerForOtherObject(bool statToApply)
    {
        foreach (GameObject obj in listOfWhatCollidWithFlaque)
        {
            obj.GetComponentInParent<Powered>().isPowered = statToApply;
        }
    }
}