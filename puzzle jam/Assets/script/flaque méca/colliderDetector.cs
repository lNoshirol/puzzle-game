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
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cable"|| collision.gameObject.tag == "boutDeCable")
        {
            listOfWhatCollidWithFlaque.Add(collision.gameObject);
            CheckIfPoweredCableTouchTheWater();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        listOfWhatCollidWithFlaque.Remove(collision.gameObject);
        CheckIfPoweredCableTouchTheWater();
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    public void CheckIfPoweredCableTouchTheWater()
    {
        foreach (GameObject obj in listOfWhatCollidWithFlaque)
        {
            if (obj.GetComponentInParent<Powered>())
            {
                GetComponent<Powered>().isPowered = true;
                ApplyPowerForOtherObject(false);
                break;
            }
            ApplyPowerForOtherObject(false);
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