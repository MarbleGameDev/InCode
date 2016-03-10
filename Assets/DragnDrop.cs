using UnityEngine;
using System.Collections;

public class DragnDrop : MonoBehaviour {
    Collider2D col;
    public GameObject canvas;
	// Use this for initialization
	void Start () {
        col = GetComponent<Collider2D>();
        canvas = GameObject.Find("Canvas");
	}
	
	// Update is called once per frame
	void Update () {

    }
    public void Drag() {
        if (this.transform.parent.Equals(canvas.transform))
            this.transform.position = Input.mousePosition;
    }
    public void Drop() {
        Collider[] colls = Physics.OverlapSphere(transform.position, 120f);
        if (colls != null) {
            foreach (Collider co in colls) {
                if ((co.transform.parent.Equals(canvas.transform) || gameObject.GetComponentsInChildren<CodeBehaviour>().Length == 1) && !co.transform.Equals(this.transform)) {
                    Debug.Log(co.transform.name);
                    this.transform.SetParent(co.transform.FindChild("Panel").transform, false);
                }
            }
        }
    }
}
