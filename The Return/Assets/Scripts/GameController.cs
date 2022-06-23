using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Player player;
    public InputField textEntryField;
    public Text logText;
    public Text curText;

    public Action[] actions;


    [TextArea]
    public string introText;

    // Start is called before the first frame update
    void Start()
    {
        logText.text = introText;
        DisplayLocation();
        textEntryField.ActivateInputField();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DisplayLocation() {

        string desc = player.currentLocation.Description+"\n";
        desc += player.currentLocation.GetConnections();
        desc += player.currentLocation.GetItemsText();
        curText.text = desc;
    
    }

    public void TextEntered() 
    {
        LogCurText();
        Process(textEntryField.text);
        textEntryField.text = "";
        textEntryField.ActivateInputField();

    }


    void LogCurText() 
    {

        logText.text += "\n\n";
        logText.text += curText.text;
        logText.text += "\n\n";
        logText.text += "<color=#accaaff>" + textEntryField.text + "</color>";
    }

    void Process(string input) {

        input = input.ToLower();
        char[] delimiter = { ' ' };
        string[] sep = input.Split(delimiter);

        foreach (Action action in actions) {

            if (action.keyword.ToLower() == sep[0]) {

                if (sep.Length > 1)
                {
                    action.Respond(this, sep[1]);
                }
                else
                {
                    action.Respond(this, "");
                }
                return;
            
            }
        }

        curText.text="You're dumb, get Help! (type Help)";
    
    }
}
