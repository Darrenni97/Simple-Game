using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField]
  private Rigidbody playerBody;

  private Vector3 inputVector;
  // Start is called before the first frame update
  void Start()
  {
    playerBody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    inputVector = new Vector3(Input.getAxisRaw("Horizontal"), playerBody.velocity.y, Input.getAxisRaw("Vertical"));
    playerBody.velocity = inputVector;
  }
}
