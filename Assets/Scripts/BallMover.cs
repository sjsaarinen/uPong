using UnityEngine;
using System.Collections;

public class BallMover : MonoBehaviour
{

    public float impulse = 0.3f;
    public Rigidbody rb;

    private bool wasPlayerCollision = false;
    private bool wasAIPlayerCollision = false;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Awake()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-transform.forward * impulse, ForceMode.Impulse);

    }
    // Update is called once per frame
    void Update()
    {
        if (wasPlayerCollision)
        {
            rb.AddForce(transform.forward * impulse, ForceMode.Impulse);
            wasPlayerCollision = false;
        }

        if (wasAIPlayerCollision)
        {
            rb.AddForce(-transform.forward * impulse, ForceMode.Impulse);
            wasAIPlayerCollision = false;
        }
    }

    void OnCollisionEnter(Collision newCollision)
    {
        if (newCollision.gameObject.tag == "Player")
        {
            Debug.Log("Player Collision");
            wasPlayerCollision = true;
        }

        if (newCollision.gameObject.tag == "AIPlayer")
        {
            Debug.Log("AI Collision");
            wasAIPlayerCollision = true;
        }

        if (newCollision.gameObject.tag == "DeathZoneTop")
        {
            Debug.Log("Death Zone top collision");
            GameManager.gm.addScore();   
        }
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        rb.AddForce(-transform.forward * impulse, ForceMode.Impulse);
    }

}

