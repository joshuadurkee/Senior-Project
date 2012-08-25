using UnityEngine;
using System.Collections;

public class StartCubeGrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5))
			{
				if (hit.collider.gameObject.tag == "Cube")
				{
					hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.animation.Play("GrowX+");
				}
			}
		}
		
		if (Input.GetMouseButtonDown(1))
		{
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5))
			{
				if (hit.collider.gameObject.tag == "Cube")
				{
					hit.collider.gameObject.GetComponent<CubeGrow>().scale = 0;
				}
			}
		}
		
	}
}
