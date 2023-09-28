using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
	AudioSource Boum;
	public GameObject worldObject;
	[SerializeField]
	private GameObject fx;
	
	

    // Start is called before the first frame update
    void Start()
    {
     	Boum = GameObject.Find("World").GetComponent<AudioSource>();
     	worldObject = GameObject.Find("World");
     	
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other) { // OnCollisionEnter
    	if (Boum) {
    	   Boum.Play();
	}
	if (other.tag == "Player") {
	   Instantiate(fx, transform.position, Quaternion.identity);
	   Destroy(gameObject);
	   worldObject.SendMessage("AddHit");
	}
    }
}
