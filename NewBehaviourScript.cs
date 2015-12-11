using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int ClearStage = PlayerPrefs.GetInt("ClearStage");
        Debug.Log(ClearStage);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
