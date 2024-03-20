using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDetector : MonoBehaviour
{
    public List<GameObject> listOfWhatCollidWithFlaque;

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
        foreach(GameObject obj in listOfWhatCollidWithFlaque)
        {
            if (obj.GetComponentInParent<Powered>())
            {
                if (obj.GetComponentInParent<Powered>().isPowered)
                {
                    foreach (GameObject lesObjets in listOfWhatCollidWithFlaque)
                    {
                        if (obj.GetComponentInParent<Powered>())
                        {
                            obj.GetComponentInParent<Powered>().isPowered = true;
                        }
                    }
                }
            }
        }
    }
}