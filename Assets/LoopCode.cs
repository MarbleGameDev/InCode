using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoopCode : MonoBehaviour, CodeBehaviour {

    public void Execute() {
        if (transform.childCount > 1) {
            InputField field = GetComponentInChildren<InputField>();
            int count = int.Parse(field.text);
            foreach (Transform ch in transform) {
                CodeBehaviour co = ch.GetComponentInChildren<CodeBehaviour>();
                if (co != null) {
                    for (int i = 0; i < count; i++)
                        co.Execute();
                }
            }
        }
    }
}
