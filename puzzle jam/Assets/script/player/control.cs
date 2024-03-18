using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    public Vector3 mouvement;
    internal Vector2 InputValue;
    public float speed;
    public Rigidbody rb;
    public Vector3 lastDirection;

    private bool isStickUse = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMoove(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            isStickUse = true;
        }
        if (callbackContext.canceled)
        {
            isStickUse = false;
        }
        Vector2 orientation = callbackContext.ReadValue<Vector2>();
        mouvement = new Vector3(InputValue.x, 0, InputValue.y);
        mouvement.x += orientation.x;
        mouvement.z += orientation.y;
        mouvement.y = 0;
        mouvement.Normalize();
    }

    private void FixedUpdate()
    {
        if (isStickUse)
        {
            transform.position = transform.position + (speed * mouvement * Time.deltaTime);

            Vector3 newPosition = transform.position + mouvement;

            // Déterminez la direction vers la nouvelle position
            Vector3 directionToNewPosition = newPosition - transform.position;

            // Créez une rotation à partir de la direction vers la nouvelle position
            Quaternion newRotation = Quaternion.LookRotation(directionToNewPosition);

            // Appliquez la nouvelle rotation à l'objet
            transform.rotation = newRotation;
        }

        if (mouvement != Vector3.zero)
        {
            lastDirection = mouvement;
        }

        
    }
}