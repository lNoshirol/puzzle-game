using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeWhenPowered : MonoBehaviour
{
    public GameObject objectToActivateIfActivateTrue;
    public GameObject objectToActivateIfActivateFalse;
    public Vector3 posToInstantiate;
    public bool lastState;

    private void Start()
    {
        
    }

    private void Update()
    {
        bool currentState = GetComponent<Powered>().isPowered;
        CheckIfStatHasChange(currentState);

        lastState = GetComponent<Powered>().isPowered;
    }

    public void CheckIfStatHasChange(bool actualStatu)
    {
        if (objectToActivateIfActivateTrue != null && objectToActivateIfActivateFalse != null)
        {
            if (actualStatu != lastState && actualStatu)
            {
                objectToActivateIfActivateFalse.SetActive(false);
                objectToActivateIfActivateTrue.SetActive(true);
            }
            else if (actualStatu != lastState && !actualStatu)
            {
                objectToActivateIfActivateTrue.SetActive(false);
                objectToActivateIfActivateFalse.SetActive(true);
            }
        }
    }
}