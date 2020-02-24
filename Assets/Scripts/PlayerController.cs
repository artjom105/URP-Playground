using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    [System.NonSerialized]
    public Vector3 moveVector;
    [System.NonSerialized]
    public float moveHorizontal;
    [System.NonSerialized]
    public float moveVerctival;
    [SerializeField]
    public float force = 10.0f;

    [SerializeField]
    public float damping = 0.5f;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        moveHorizontal = Input.GetAxis("Horizontal");  
        moveVerctival = Input.GetAxis("Jump");      
        moveVector = new Vector3(moveHorizontal,moveVerctival,0.0f);
        if(characterController.isGrounded){
            characterController.Move(moveVector);
        }
        if(!characterController.isGrounded){            
            moveVector += Physics.gravity * Time.deltaTime;            
            moveVector.x = moveVector.x/2;
            characterController.Move(moveVector); 
        }

    }
}
