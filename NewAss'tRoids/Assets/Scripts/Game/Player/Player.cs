using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //variables
    public float movementSpeed = 10f;
    public float rotationSpeed = 230f;
    private Rigidbody2D rigid;
    
    
    
    // Use this for initialization
	void Start () {
        rigid = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Control();
	}

    void Control()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        //rotate to left
        this.transform.Rotate(Vector3.forward, -inputHorizontal * rotationSpeed * Time.deltaTime);
        //forward backwards
        rigid.AddForce(inputVertical*transform.up*movementSpeed);
    }
}
