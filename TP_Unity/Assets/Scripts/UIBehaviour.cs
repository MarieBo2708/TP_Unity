using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    TMP_Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void AddHit() {
	GameVariables.catHeads++;
	headText.text = "CatBots touchés : " + GameVariables.catHeads;
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
	SceneManager.LoadScene("dragon_house"); // le nom de votre scene
   }
}
