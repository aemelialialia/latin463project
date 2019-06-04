using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    [SerializeField] [TextArea(14, 10)] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] string[] buttons;

    public string GetStoryText()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

    public string[] GetButtons()
    {
        return buttons;
    }

    public string GetButtonsText(int choice)
    {
        return buttons[choice];
    }
}
