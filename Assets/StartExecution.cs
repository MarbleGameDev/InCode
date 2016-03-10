using UnityEngine;
using System.Collections;

public class StartExecution : MonoBehaviour {

    public void Click() {
        GameObject.Find("Start(Clone)").GetComponentInChildren<StartCode>().Execute();
    }
}
