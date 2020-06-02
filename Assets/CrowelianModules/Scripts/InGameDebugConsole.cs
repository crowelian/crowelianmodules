using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// An In-Game debug console for seeing errors at runtime while testing your game / app.
/// </summary>

public class InGameDebugConsole : MonoBehaviour
{

    public Text consoleText; // output the debug console to this UI Text
    private string logString; // contains the Unity debug.log!

    private void Awake()
    {
        Application.logMessageReceived += OnLogMessage;
        //Debug.Log("TEST!");
        //Debug.LogError("ERRORTEST!");
    }

    private void OnLogMessage(string condition, string stackTrace, LogType type)
    {
        string pre = "";
        string after = "";

        // Check the type of debug log
        if (type == LogType.Error)
        {
            pre = "<color=red>";
            after = "</color>";
        }
        else if (type == LogType.Warning)
        {
            pre = "<color=red>";
            after = "</color>";
        }
        else
        {
            pre = "<color=green>";
            after = "</color>";
        }

        var typePrefix = type != LogType.Log ? type + ": " : "";
        logString += pre + DateTime.Now.ToLongTimeString() + "> " + typePrefix + condition + after + "\n";

        if (consoleText != null)
            consoleText.text = logString;
        

    }

}
