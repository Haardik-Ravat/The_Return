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

        // something something

        curText.text="You're dumb, get Help! (type Help)";
    
    }
}
