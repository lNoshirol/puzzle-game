using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorLight : MonoBehaviour
{
    public List<Light> lightList;

    void Update()
    {
        if (GetComponent<Powered>().isPowered)
        {
            foreach (Light light in lightList)
            {
                light.color = Color.green;
            }
        }
        else if (!GetComponent<Powered>().isPowered) 
        {
            foreach (Light light in lightList)
            {
                light.color = Color.red;
            }
        }
    }
}
