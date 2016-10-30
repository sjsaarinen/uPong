using UnityEngine;
using System.Collections;

public class PlayerGameOver : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        GameManager.gm.EndGame();
    }

}