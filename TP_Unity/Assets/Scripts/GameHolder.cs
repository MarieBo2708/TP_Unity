using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHolder : MonoBehaviour
{
     TMP_Text timerText;
     TMP_Text pieceText;
    // Start is called before the first frame update
    void Start()
    {
    	timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
    	pieceText = GameObject.Find("lblCount").GetComponent<TMPro.TMP_Text>();
	StartCoroutine(TimerTick());
        //Debug.Log("Timer : " + GameVariables.currentTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddHit() {
	GameVariables.Pieces++;
	pieceText.text = "Pieces attrapees : " + GameVariables.Pieces;
    }
    
     IEnumerator TimerTick() {
	while (GameVariables.currentTime > 0)
	{
		// attendre une seconde
		yield return new WaitForSeconds(1);
		GameVariables.currentTime--;
		timerText.text = "Time :" + GameVariables.currentTime.ToString();
	}
	// game over
	SceneManager.LoadScene("environnement"); // le nom de votre scene
   }
}
