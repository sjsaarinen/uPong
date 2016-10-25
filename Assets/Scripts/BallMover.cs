using UnityEngine;
using System.Collections;

public class BallMover : MonoBehaviour {

    public float speed = 1;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = -transform.forward * speed;

    }
    // Update is called once per frame
    void Update () {
	
	}
}
