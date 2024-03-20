using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConnector : MonoBehaviour
{
    public GameObject[] Objs;

    private LineRenderer line;

    private void Start()
    {
        line = this.gameObject.GetComponent<LineRenderer>();
        line.positionCount = Objs.Length;
    }

    private void Update()
    {
        for (int i = 0; i < Objs.Length; i++)
        {
            line.SetPosition(i, Objs[i].transform.position);
        }
    }
}