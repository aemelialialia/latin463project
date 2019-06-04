using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApolloGame : MonoBehaviour
{

    [SerializeField] Text conversation;
    [SerializeField] Text button1;
    [SerializeField] Text button2;
    [SerializeField] Text button3;
    [SerializeField] Text button4;

    [SerializeField] Button choice1;
    [SerializeField] Button choice2;
    [SerializeField] Button choice3;
    [SerializeField] Button choice4;

    [SerializeField] Button continues;
    [SerializeField] Button end;

    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        conversation.text = state.GetStoryText();
        continues.gameObject.SetActive(false);
        end.gameObject.SetActive(false);

        if (state.GetButtonsText(1) == "") {
            choice2.gameObject.SetActive(false);
        }

        if (state.GetButtonsText(2) == "")
        {
            choice3.gameObject.SetActive(false);
        }

        if (state.GetButtonsText(3) == "")
        {
            choice4.gameObject.SetActive(false);
        }

        button1.text = state.GetButtonsText(0);
        button2.text = state.GetButtonsText(1);
        button3.text = state.GetButtonsText(2);
        button4.text = state.GetButtonsText(3);
    }

    public void ManageState(int decision)
    {
        var nextStates = state.GetNextStates();
        state = nextStates[decision];
        conversation.text = state.GetStoryText();
        if (state.GetNextStates().Length == 0)
        {
            continues.gameObject.SetActive(true);
            end.gameObject.SetActive(true);
        }

        if (state.GetButtonsText(0) == "")
        {
            choice1.gameObject.SetActive(false);
        }

        if (state.GetButtonsText(0) == "")
        {
            choice1.gameObject.SetActive(false);
        }

        if (state.GetButtonsText(1) == "")
        {
            choice2.gameObject.SetActive(false);
        }

        if (state.GetButtonsText(2) == "")
        {
            choice3.gameObject.SetActive(false);
        }

        if (state.GetButtonsText(3) == "")
        {
            choice4.gameObject.SetActive(false);
        }

        button1.text = state.GetButtonsText(0);
        button2.text = state.GetButtonsText(1);
        button3.text = state.GetButtonsText(2);
        button4.text = state.GetButtonsText(3);
    }
}