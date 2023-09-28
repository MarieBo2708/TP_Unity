using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceBehaviour : MonoBehaviour
{
    public GameObject worldObject;
    AudioSource ding;
    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("GameHolder");
        ding = GameObject.Find("GameHolder").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    	
	transform.Rotate(10, 0, 0, Space.Self);
    }
    
    void OnTriggerEnter(Collider collision){
    	if (ding) {
    	   ding.Play();
	}
    	if(collision.tag == "Player"){
    		Destroy(gameObject);
    		worldObject.SendMessage("AddHit");
    	}
    }
}
