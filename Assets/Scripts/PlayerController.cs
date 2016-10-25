using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    // public variables
    public float speed = 3.0f;
    //public float gravity = 9.81f;

    private CharacterController characterController;
    private Rigidbody rigidbody;
    private Vector3 positionYZ;

    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * speed * Time.deltaTime;
        
        Vector3 movement = transform.TransformDirection(movementX);

        
        Debug.Log("Movement Vector = " + movement);

        var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (x > -3 && x < 3)
        {
            transform.Translate(x, 0.0f, 0.0f);
        }
        // Actually move the character controller in the movement direction
        //rigidbody.MovePosition(transform.position + movement);
        //transform.position.Set(transform.position.x, 0.0f, 0.0f);
    }
}
