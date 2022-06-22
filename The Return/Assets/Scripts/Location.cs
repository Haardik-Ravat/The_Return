using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public string Location_Name;
    [TextArea]
    public string Description;

    public Connections[] connections;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
