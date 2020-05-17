using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue dialogue;

    public void TriggerDialogue(){
        FindObjectOfType<DialogueManger>().StartDialogue(dialogue);
    }

    public void TriggerMessages(){
        StopAllCoroutines();
        StartCoroutine(messagesHelper());
    }

    IEnumerator messagesHelper(){
        yield return new WaitForSeconds(3);
        FindObjectOfType<MessagingManger>().StartDialogue(dialogue);
    }
    public void TriggerMessages1(){
        StopAllCoroutines();
        StartCoroutine(messagesHelper1());
    }
    IEnumerator messagesHelper1(){
        yield return new WaitForSeconds(3);
        FindObjectOfType<MessagingManger>().StartDialogue1(dialogue);
    }

}
