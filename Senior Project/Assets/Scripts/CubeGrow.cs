using UnityEngine;
using System.Collections;

public class CubeGrow : MonoBehaviour {
	
	public float scale;
	public bool grown;
	
	// Use this for initialization
	void Start () {
		scale = 0;
		//this.gameObject.transform.localScale = new Vector3(0,1,1);
		//this.gameObject.animation.Play("GrowX+");
	}
	
	// Update is called once per frame
	void Update () {
		/*if(this.gameObject.transform.localScale.x < scale)
		{
			this.gameObject.transform.localScale += new Vector3(0.01F,0,0);
		}
		
		if(this.gameObject.transform.localScale.x > scale)
		{
			this.gameObject.transform.localScale -= new Vector3(0.01F,0,0);
		}*/
	}
}
