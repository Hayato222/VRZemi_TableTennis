using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace ObjectTarget
{
    public class RacketController : MonoBehaviour
    {
        private InputDevice rightController;
        private Vector3 previousPosition;
        private Vector3 velocity;
        [SerializeField]private float nerfPower = 100f;
    
        private void Start()
        {
            InitializeDevices();
            previousPosition = transform.position;
        }
    
        private void InitializeDevices()
        {
            var rightHandDevices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHandDevices);
    
            if (rightHandDevices.Count > 0)
                rightController = rightHandDevices[0];
        }
    
        private void Update()
        {
            // ラケットの速度を計算
            velocity = (transform.position - previousPosition) / Time.deltaTime;
    
            // 次のフレーム用に現在の位置を保存
            previousPosition = transform.position;
        }
    
        private void FixedUpdate()
        {
            if (rightController.isValid)
            {
                // コントローラーの速度を取得
                if (rightController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 controllerVelocity))
                {
                    // コントローラーの速度をラケットの速度に加算
                    velocity += controllerVelocity;
                }
            }
        }
    
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ball"))
            {
                Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
                if (ballRigidbody != null)
                {
                    // ラケットの速度をボールに伝える
                    ballRigidbody.velocity = velocity/nerfPower;
    
                    // ラケットの力をボールに加える
                    ballRigidbody.AddForce(velocity/nerfPower, ForceMode.Impulse);
                }
            }
        }
    }
}

