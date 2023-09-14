using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 3f; // Unity-enheter per sekund

    [SerializeField]
    float rotationSpeed = 150f; // Grader per sekund
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {

    float yRotation = Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime;
    float zMovement = Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime;

    Vector3 rotationVector = new Vector3(0, yRotation, 0);
    Vector3 movementVector = new Vector3(0, 0, zMovement);

    transform.Rotate(rotationVector);
    transform.Translate(movementVector);   
    }
}
