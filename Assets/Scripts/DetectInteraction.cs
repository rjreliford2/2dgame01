using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInteraction : MonoBehaviour
{
    public GameObject partner;
	public ObjectInteract objectScript;
	public InitiateDialogue dialogueScript;
	public EndLevel endLevelScript;
	public ChocolateMilkBool chocMilkScript;
	public GameObject speakUp;
	public GameObject dad;
	
    void Update(){
    	if (speakUp.activeInHierarchy == true && partner == dad){
    		if(Input.GetKeyDown("e")){
    			LoadScene exit = dad.GetComponent<LoadScene>();
                exit.NextScene("OutroStory");
    		}
    	} 
    }
    void OnTriggerEnter2D(Collider2D other)
    {
	    partner = other.gameObject;
		if (partner.GetComponent<IsObject>() != null)
		{
			objectScript.enabled = true;
		}
		if (partner.GetComponent<HasDialogue>() != null)
		{
			dialogueScript.enabled = true;
			speakUp.SetActive(true);
		}
		if (partner.GetComponent<IsBed>() != null)
		{
			endLevelScript.enabled = true;
		}
		if (partner.GetComponent<IsChocMilk>() != null)
		{
			chocMilkScript.enabled = true;
		}
		if (partner.GetComponent<ExitPath>() != null)
        {
			LoadScene exit = partner.GetComponent<LoadScene>();
            exit.NextScene("Neighborhood");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
	    partner = null;
		objectScript.enabled = false;
		dialogueScript.enabled = false;
		endLevelScript.enabled = false;
		chocMilkScript.enabled = false;
		speakUp.SetActive(false);
    }
}
