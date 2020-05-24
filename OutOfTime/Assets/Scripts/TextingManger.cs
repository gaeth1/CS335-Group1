using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextingManger : MonoBehaviour
{
    public Text nameText1;
    public Text dialogueText1;

    public Animator animator1;
    public Animator optionsAnimator;

    public Queue<string> sentances;
    public Button secondButton;
    void Start()
    {
        sentances = new Queue<string>();
        secondButton.onClick.Invoke();
    }
    public void StartDialogue1(Dialogue dialogue){
        animator1.SetBool("isOpen", true);
        sentances.Clear();
        nameText1.text = dialogue.name;
        foreach(string sentance in dialogue.sentances){
            sentances.Enqueue(sentance);
        }
        DisplayNextSentances1();
    }

    public void DisplayNextSentances1(){
        FindObjectOfType<AudioManger>().Play("soundEffect1");
        if(sentances.Count==0){
            EndDialogue1();
            return;
        }
        string sentance = sentances.Dequeue();
        dialogueText1.text = sentance;

    }

    void EndDialogue1(){
        optionsAnimator.SetBool("isOpen", true);
    }
}
