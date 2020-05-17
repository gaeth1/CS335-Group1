using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManger : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Text dialogueT;
<<<<<<< HEAD

=======
    public LoadScene sceneManger; 
>>>>>>> Gaeth-Play
    public Text oceanDialogue;
    public Animator animator;
    private Queue<string> sentances;
    int counter=0;

    public Button startButton; 
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManger>().Play("News");
        sentances = new Queue<string>();
        dialogueT=dialogueText;
        oceanDialogue.gameObject.SetActive(false);
        startButton.onClick.Invoke();
<<<<<<< HEAD

=======
>>>>>>> Gaeth-Play
    }

    public void StartDialogue(Dialogue dialogue){
        animator.SetBool("isOpen", true);
        nameText.text=dialogue.name;
        sentances.Clear();

        foreach(string sentance in dialogue.sentances){
            sentances.Enqueue(sentance);
        }
        DisplayNextSentance();
    }

    public void DisplayNextSentance(){
        if(counter!=0)
        {
            oceanDialogue.gameObject.SetActive(true);
            dialogueT=oceanDialogue;
            dialogueText.gameObject.SetActive(false);
        }
        if(sentances.Count==0){
            EndDialogue();
            return;
        }
        string sentance =sentances.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentance(sentance));
        counter++;

    }

    IEnumerator TypeSentance(string sentance){
        dialogueT.text = "";
        foreach(char letter in sentance.ToCharArray()){
            dialogueT.text+=letter;
            yield return new WaitForSeconds((float) 0.1);
        }
    }
    void EndDialogue(){
<<<<<<< HEAD
        animator.SetBool("isOpen", false);
        Debug.Log("End");
=======
        sceneManger.FadeToLevel(2);
        
>>>>>>> Gaeth-Play
    }

}
