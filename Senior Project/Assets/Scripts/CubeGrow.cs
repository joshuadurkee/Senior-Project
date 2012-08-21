using UnityEngine;
using System.Collections;

public class CubeGrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.transform.localScale = new Vector3(0,1,1);;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.localScale.x < 1)
		{
			this.gameObject.transform.localScale += new Vector3(0.01F,0,0);
		}
	}
}
