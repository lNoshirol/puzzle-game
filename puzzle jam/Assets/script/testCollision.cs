using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && GetComponent<Powered>().isPowered)
        {
            Debug.Log("PLAYER ENTER");
        }
    }
}
