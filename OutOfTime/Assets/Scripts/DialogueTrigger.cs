﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue dialogue;

    public void TriggerDialogue(){
        FindObjectOfType<DialogueManger>().StartDialogue(dialogue);
    }
    public void TriggerParty(){
        FindObjectOfType<PartyDialogue>().StartDialogue(dialogue);
    }
    public void TriggerCupGirl(){
        FindObjectOfType<CupGirl>().StartDialogue(dialogue);
    }
    public void TriggerNPC(){
        FindObjectOfType<NPCDialogue>().StartDialogue(dialogue);
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
    public void TriggerMessages2(){
        StopAllCoroutines();
        StartCoroutine(messagesHelper2());
    }
    IEnumerator messagesHelper2(){
        yield return new WaitForSeconds(3);
        FindObjectOfType<TextingManger>().StartDialogue1(dialogue);
    }
}
