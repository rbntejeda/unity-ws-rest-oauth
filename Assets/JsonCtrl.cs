using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonCtrl : MonoBehaviour {
    public JSONObject jsonObject;
    public string texto;
	// Use this for initialization
	void Start () {
        jsonObject = new JSONObject(texto);
        Debug.Log(jsonObject["fac"]["tie"]["asde"]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
