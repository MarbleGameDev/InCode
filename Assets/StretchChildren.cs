using UnityEngine;
using System.Collections;

public class StretchChildren : MonoBehaviour {

	void Update () {
        GetComponent<RectTransform>().sizeDelta = new Vector2(160, (transform.childCount * 30));
    }
}
