using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FotusGame : MonoBehaviour
{

    [SerializeField] Text conversation;
    [SerializeField] Button continues;
    [SerializeField] Button onlyOption;

    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        conversation.text = state.GetStoryText();
        continues.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
