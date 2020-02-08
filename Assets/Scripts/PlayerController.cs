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
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVerctival = Input.GetAxis("Vertical");
        moveVector = new Vector3(moveHorizontal,moveVerctival,0.0f);
        characterController.Move(moveVector);
    }
}
