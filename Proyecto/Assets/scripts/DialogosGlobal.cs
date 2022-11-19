using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogosGlobal : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Animator animator;
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();



    }

    // Update is called once per frame
    public void StartDialogue(Dialogo dialogo)
    {
        animator.SetBool("Abierto", true);
        nameText.text = dialogo.name;
        sentences.Clear();
        foreach (string sentence in dialogo.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("Abierto", false);
        
    }

    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            DisplayNextSentence();
        }
    }
}

