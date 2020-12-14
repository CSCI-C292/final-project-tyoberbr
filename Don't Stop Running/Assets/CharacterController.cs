using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private LayerMask platformslayerMask; 
    //private CharacterController_Base Character;
    private Rigidbody2D rigidbody2d; 
    private BoxCollider2D boxCollider2D; 
    public float moveSpeed = 5f; 

    private void Awake() {
        //Character = gameObject.GetComponent<CharacterController_Base>(); 
        rigidbody2d = transform.GetComponent<Rigidbody2D>(); 
        boxCollider2D = transform.GetComponent<BoxCollider2D>();  
    }

    private void Update() {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); 
        transform.position += movement * Time.deltaTime * moveSpeed; 

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space)) {
            float jumpVelocity = 40f; 
            rigidbody2d.velocity = Vector2.up * jumpVelocity; 
        }
    }

    private bool IsGrounded() {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, platformslayerMask); 
        return raycastHit2d.collider != null; 
    }



    //private void HandleMovement() { 
      //  float moveSpeed = 40f; 
        //if (Input.GetKey(KeyCode.LeftArrow)) {
          //  rigidbody2d.velocity = new Vector2(moveSpeed, rigidbody2d.velocity.y); 
        //} else {
          //  if (Input.GetKey(KeyCode.RightArrow)) {
            //    rigidbody2d.velocity = new Vector2(moveSpeed, rigidbody2d.velocity.y); 
            //} else { 
              //  rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y); 
            //}
        //}
    //}
}