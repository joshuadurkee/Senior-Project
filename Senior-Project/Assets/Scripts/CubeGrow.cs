using UnityEngine;
using System.Collections;

public class CubeGrow : MonoBehaviour {
	
	public Vector3 offset;
	public Animation grow;
	public Animation shrink;
	public GameObject newCube;
	
	// Use this for initialization
	void Start () {
		//scale = 0;
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
	
	void growNewCube()
	{
		Instantiate(newCube, this.gameObject.transform.parent.position + offset, Quaternion.identity);
	}
	
	void shrinkCube()
	{
		Destroy(this.gameObject.transform.parent.gameObject);
	}
}
