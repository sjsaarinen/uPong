using UnityEngine;
using System.Collections;

public class AIMover : MonoBehaviour {

    public float speed = 2.5f;
    private Transform ballTransform;

    void Start()
    {
        GameObject ballGameObject = GameObject.Find("Ball");
        ballTransform = ballGameObject.transform;
    }

    void FixedUpdate()
    {
        float inputSpeed = 0f;

        if (ballTransform.position.z > transform.position.z)
        {
            inputSpeed = 1f;
        }
        else if (ballTransform.position.z < transform.position.z)
        {
            inputSpeed = -1f;
        }

        Vector3 position = transform.position + new Vector3(inputSpeed * speed * Time.deltaTime, 0f, 0f);

        if (inputSpeed > 1f)
        {
            if (position.x > ballTransform.position.x)
            {
                position.x = ballTransform.position.x;
            }
        }
        else if (inputSpeed < 1f)
        {
            if (position.x < ballTransform.position.x)
            {
                position.x = ballTransform.position.x;
            }
        }

        transform.position = position;
    }
}
