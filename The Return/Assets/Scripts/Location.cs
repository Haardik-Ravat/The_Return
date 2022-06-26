using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public string Location_Name;
    [TextArea]
    public string Description;

    public Connections[] connections;

    public List<item> items = new List<item>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetItemsText()
    {
        if (items.Count == 0) return "";

        string result = "You see";
        bool first = true;


        foreach (item ite in items) {
            if (ite.ItemEnabled)
            {
                if (!first) result += " and ";

                result += ite.desc;
                first = false;
            }
        }
        result += "\n";
        return result;
    }


    public string GetConnections() {
        string res = "";

        foreach (Connections con in connections) {
            if (con.connectionEnabled) {
                res += con.Description + "\n";
            }
        }

        return res;    
    
 
    }
    
    public Connections GetConnection(string conNoun)
    {
        foreach (Connections con in connections) 
        {
            if (con.ConnectionName.ToLower() == conNoun.ToLower()) 
            {
                return con;
            }

        }

        return null;
    }


}
