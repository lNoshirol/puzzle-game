using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDetector : MonoBehaviour
{
    public List<GameObject> listOfWhatCollidWithFlaque;

    private void OnCollisionEnter(Collision collision)
    {
        listOfWhatCollidWithFlaque.Add(collision.gameObject);
    }
}
