using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicBall : MonoBehaviour
{
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void EnableRigidbody(bool enable)
    {
        _rigidbody.constraints = enable ? RigidbodyConstraints.None : RigidbodyConstraints.FreezeAll;
    }

}
