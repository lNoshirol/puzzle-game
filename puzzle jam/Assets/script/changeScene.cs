using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public string LASCENE;
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(LASCENE)
    }
}
