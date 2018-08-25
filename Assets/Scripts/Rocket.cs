using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Rigidbody rocketRigidBody;
    [SerializeField] public float forceForward = 20;
    // Use this for initialization
    void Start()
    {
        rocketRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update()
    {
        Voler();
        BougerGaucheDroite();
    }

    private void Voler()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            rocketRigidBody.AddRelativeForce(Vector3.up * 200);
        }
    }

    private void BougerGaucheDroite()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rocketRigidBody.AddForceAtPosition(Vector3.right * forceForward, transform.position);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rocketRigidBody.AddForceAtPosition(Vector3.left * forceForward, transform.position);
        }
    }
}
