using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 3.0f;
    public float touchSpeed = 0.1f;

    void FixedUpdate()
    {
        
        //keyboard controls
        var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(0.0f, -x, 0.0f);

        //touch controls
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            double halfScreen = Screen.width / 2.0;

            if (touchPosition.x < halfScreen)
            {
                transform.Translate(0.0f, touchSpeed, 0.0f);
                //transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else if (touchPosition.x > halfScreen)
            {
                transform.Translate(0.0f, -touchSpeed, 0.0f);
                //transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

        }

    }
}
