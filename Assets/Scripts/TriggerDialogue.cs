using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TriggerDialogue : MonoBehaviour
{
    public Dialogue dialogue;
    public TextMeshProUGUI startText;
    public int startNext;
    public string newText;
    
    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (startNext == 0)
            {
                DialogueTrigger();
                startText.text = newText;
                startNext++;
            }

            if (startNext > 0)
            {
                FindObjectOfType<HandleDialogue>().DisplayNext();
            }
        }
    }

    public void DialogueTrigger()
    {
        FindObjectOfType<HandleDialogue>().StartDialogue(dialogue);
    }
}
