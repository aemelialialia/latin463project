using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FotusGame : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI conversation;
    [SerializeField] TextMeshProUGUI name;
    [SerializeField] Button continues;

    [SerializeField] State startingState;

    Dialogue dialogue;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        conversation.text = state.GetStoryText();
        name.text = dialogue.name;
        continues.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
