using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float heroSpeed = 10f;
    public float heroRotateSpeed = 100f;

    private float verInput;
    private float horInput;

    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        verInput = Input.GetAxis("Vertical") * heroSpeed;
        horInput = Input.GetAxis("Horizontal") * heroRotateSpeed;
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * horInput;
        Quaternion angelRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * verInput * Time.fixedDeltaTime);
        _rb.MoveRotation(angelRot * _rb.rotation);
    }

}
