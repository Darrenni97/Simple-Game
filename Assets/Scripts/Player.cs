using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField]
  private Rigidbody playerBody;
  // Start is called before the first frame update
  void Start()
  {
    playerBody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    playerBody.velocity = new Vector3(2f, playerBody.velocity.y, 2f);
  }
}
