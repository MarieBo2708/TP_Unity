using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider collision){
    	if(collision.tag == "Player" && GameVariables.catHeads > 3){
    		SceneManager.LoadScene("environnement"); 
    	}
    }
    
}
