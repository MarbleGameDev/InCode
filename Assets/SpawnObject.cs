using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {
    public Transform Obj;
    public Transform canvas;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Click() {
        Transform trans = (Transform)GameObject.Instantiate(Obj);
        trans.SetParent(canvas, false);
        transform.position.Set(Screen.width / 2, Screen.height / 2, 0);
    }
    void OnMouseOver() {
        Debug.Log(transform.name);
    }
}
