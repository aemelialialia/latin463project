using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour

{
    private Queue<string> sentences;

    public TextMeshProUGUI nametext;
    public TextMeshProUGUI dialogueText;

    public Animator anim;

    // Start is called before the first frame update
    public void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Starting conversation with" + dialogue.name);

        anim.SetBool("isOpen", true);

        nametext.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        //Debug.Log("Displaying another sentence.");

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentenceToType)
    {
        dialogueText.text = "";
        foreach (char letter in sentenceToType.ToCharArray())
        {
            dialogueText.text += letter;

            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation. Bye.");

        anim.SetBool("isOpen", false);
    }

    public Queue<string> GetSentences()
    {
        return sentences;
    }
}
