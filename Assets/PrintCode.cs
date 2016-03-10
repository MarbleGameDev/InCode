using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PrintCode : MonoBehaviour, CodeBehaviour{
    public void Execute() {
        string text = GetComponentInChildren<InputField>().text;
        Debug.Log(text);
    }
}
