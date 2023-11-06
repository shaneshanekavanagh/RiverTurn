using UnityEngine;

public class birdieScript : MonoBehaviour {

    private Transform myTransform;
    public Transform bexplosion;
	Transform target;

    public float moveSpeed;
    public float rotationSpeed;
 
    private bool fly = false;

    void Awake()
    {
       myTransform = transform;
    }
	
	void Start ()
    {
        fly = false;
        GameObject go = GameObject.FindGameObjectWithTag("birdiet");
        target = go.transform;       
    }
	
	void Update ()
    {
		if(fly == true)
        {
            Transform plosion;
			plosion = Instantiate(bexplosion, transform.position, transform.rotation) as Transform;

			moveSpeed = moveSpeed +1f;
			rotationSpeed = rotationSpeed +0.1f;

            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}

		if(transform.position.x < - 120 && transform.position.y > 70 )
        {
			Destroy(gameObject);
		}		
	}

    void OnTriggerEnter(Collider other)
    {      
		if(other.GetComponent<Collider>().gameObject.tag=="LineOf")
        {		
			fly = true;	
		}		
	}
}
