using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour {

    //variables
    public GameObject[] AsteroidsPrefabs;
    public float maxVelocity; //max velocity we will give our asteroid (weuse it to influence [Random]
    public float spawnRate;
    public float spawnPadding;
    
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //spans an (a single) asteroid at the random location with random force
    public void Spawn(GameObject prefab, Vector3 position)
    {
        //randomize the rotation of the asteroid
        Quaternion randomRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 30f));

        //spawn random asteroid at random positoin and default Quaternionf
        GameObject asteroid = Instantiate(prefab, position, randomRotation, this.transform);

        //get rigid body from asteroid 
        Rigidbody2D rigid = asteroid.GetComponent<Rigidbody2D>();

        //apply random force to rigid body
        Vector2 randomForce = Random.insideUnitCircle * maxVelocity;
        rigid.AddForce(randomForce, ForceMode2D.Impulse);
    }

    //
}
