using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//using Debug = UnityEngine.Debug;
//using Quaternion= UnityEngine.Quaternion;
//using Vector3 = UnityEngine.Vector3;


public class Program : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;

    [SerializeField] private GameObject ballPrefab;

    [SerializeField] private float power = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            GameObject ball;
            Rigidbody ballRigidbody;

            Debug.Log("x");

            ball = Instantiate(ballPrefab, SpawnPoint.position, Quaternion.identity);

            ballRigidbody = ball.GetComponent<Rigidbody>();

            ballRigidbody.AddForce(new Vector3(0f, power, 0f), ForceMode.Impulse);
        }
    }
}