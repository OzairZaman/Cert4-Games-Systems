using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Player : MonoBehaviour
    {
        public float movementSpeed = 10f;
        public float rotationSpeed = 10f;

        private Rigidbody2D rigid; // ref to our rigid body
        
        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            print("Collision Happened")
        }

        // Update is called once per frame
        void Update()
        {
            // detect if we are moving forward / backwards
            //if w is pressed add force
            if (Input.GetKey(KeyCode.W))
            {
                //add force
                rigid.AddForce(this.transform.up * movementSpeed);
            }

            //if s is pressed add force
            if (Input.GetKey(KeyCode.S))
            {
                //add force
                rigid.AddForce(this.transform.up * -movementSpeed); // could use Vector3.Up * -movementSpeed
            }

            //if d is pressed add force
            if (Input.GetKey(KeyCode.D))
            {
                //add clockwise (need to add delta time)
                rigid.rotation -= rotationSpeed * Time.deltaTime;
            }

            //if a is pressed add force
            if (Input.GetKey(KeyCode.A))
            {
                //add counter-clockwise (need to add deltatime)
                rigid.rotation += rotationSpeed *  Time.deltaTime;
            }
        }
    } 
}
