using UnityEngine;
using System.Collections;

public class StartCode : MonoBehaviour {

	// Use this for initialization
	public void Execute () {
        if (transform.childCount > 1) {
            foreach (Transform ch in transform) {
                CodeBehaviour co = ch.GetComponentInChildren<CodeBehaviour>();
                if (co != null) {
                    co.Execute();
                }
            }
        }
	}
	
}
