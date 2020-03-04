﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField]
  private Rigidbody playerBody;
  private bool jump;

  private Vector3 inputVector;
  // Start is called before the first frame update
  void Start()
  {
    playerBody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    //calculate movement input
    inputVector = new Vector3(Input.GetAxis("Horizontal") * 10f, playerBody.velocity.y, Input.GetAxis("Vertical") * 10f);
    //character facing movement direction
    transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

    if (Input.GetButtonDown("Jump"))
    {
      jump = true;
    }
  }

  private void FixedUpdate()
  {
    playerBody.velocity = inputVector;

    if (jump && IsGrounded())
    {
      playerBody.AddForce(Vector3.up * 20f, ForceMode.Impulse);
      jump = false;
    }
  }

  bool IsGrounded()
  {
    float distance = GetComponent<Collider>().bounds.extents.y + 0.01f;
    Ray ray = new Ray(transform.position, Vector3.down);
    return Physics.Raycast(ray, distance);
  }
}