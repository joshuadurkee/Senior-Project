using UnityEngine;
using System.Collections;

public class StartCubeGrow : MonoBehaviour {
	
	public GameObject cube;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = camera.ScreenPointToRay(new Vector3(camera.pixelWidth/2, camera.pixelHeight/2, 0));
			if (Physics.Raycast(ray, out hit, 10))
			{
				
				if (hit.collider.gameObject.tag == "CubeSideX+")
				{
					//hit.collider.gameObject.transform.parent.animation.Play("GrowX+");
					GameObject newCube = Instantiate(cube, this.transform.position, Quaternion.identity) as GameObject;
					newCube.transform.position += new Vector3(5,0,0);
				}
				if (hit.collider.gameObject.tag == "CubeSideX-")
				{
					hit.collider.gameObject.transform.parent.animation.Play("GrowX-");
				}
				if (hit.collider.gameObject.tag == "CubeSideY+")
				{
					hit.collider.gameObject.transform.parent.animation.Play("GrowY+");
				}
				if (hit.collider.gameObject.tag == "CubeSideY-")
				{
					hit.collider.gameObject.transform.parent.animation.Play("GrowY-");
				}
				if (hit.collider.gameObject.tag == "CubeSideZ+")
				{
					hit.collider.gameObject.transform.parent.animation.Play("GrowZ+");
				}
				if (hit.collider.gameObject.tag == "CubeSideZ-")
				{
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