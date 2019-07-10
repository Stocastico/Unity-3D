using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NeskaWalkHandler : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public double EPSILON = 0.001;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float z = CrossPlatformInputManager.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0, z);
        _rigidbody.velocity = movement * 0.25f;
        if (System.Math.Abs(x) > EPSILON && System.Math.Abs(z) > EPSILON)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,
                                                Mathf.Atan2(x, z) * Mathf.Rad2Deg,
                                                transform.eulerAngles.z);
        }
    }
}
