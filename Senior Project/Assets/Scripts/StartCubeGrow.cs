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
				if (hit.collider.gameObject.tag == "CubeSideX+")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("GrowX+");
				}
				if (hit.collider.gameObject.tag == "CubeSideX-")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("GrowX-");
				}
				if (hit.collider.gameObject.tag == "CubeSideY+")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("GrowY+");
				}
				if (hit.collider.gameObject.tag == "CubeSideY-")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("GrowY-");
				}
				if (hit.collider.gameObject.tag == "CubeSideZ+")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("GrowZ+");
				}
				if (hit.collider.gameObject.tag == "CubeSideZ-")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("GrowZ-");
				}
			}
		}
		
		if (Input.GetMouseButtonDown(1))
		{
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5))
			{
				if (hit.collider.gameObject.tag == "CubeSideX+")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("ShrinkX+");
				}
				if (hit.collider.gameObject.tag == "CubeSideX-")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("ShrinkX-");
				}
				if (hit.collider.gameObject.tag == "CubeSideY+")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("ShrinkY+");
				}
				if (hit.collider.gameObject.tag == "CubeSideY-")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("ShrinkY-");
				}
				if (hit.collider.gameObject.tag == "CubeSideZ+")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("ShrinkZ+");
				}
				if (hit.collider.gameObject.tag == "CubeSideZ-")
				{
					//hit.collider.gameObject.GetComponent<CubeGrow>().scale = 1;
					hit.collider.gameObject.transform.parent.animation.Play("ShrinkZ-");
				}
			}
		}
		
	}
}
