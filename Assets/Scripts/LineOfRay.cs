using UnityEngine;

public class LineOfRay : MonoBehaviour {
	
	public Transform target;
	public float speed;
    	
	void Start ()
    {
	
	}

    void Update()
    {
        if(target != null)
        {
		    transform.position = new Vector3(target.transform.position.x,target.transform.position.y,target.transform.position.z);
		
		    float step = speed * Time.deltaTime;
		    transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
        }
	}

    void FixedUpdate()
    {

    }
}
