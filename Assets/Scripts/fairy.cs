using UnityEngine;

public class fairy : MonoBehaviour {

	public Transform bexplosion;
	public Transform spexplosion;
	
 	private int fairyLife = 10;

	void Start ()
    {
	    fairyLife = 10;
	}

    public void HitStart()
    {
        if (fairyLife < 1)
        {
            Transform plosion;
            plosion = Instantiate(bexplosion, transform.position, transform.rotation) as Transform;

            Transform splosion;
            splosion = Instantiate(spexplosion, transform.position, transform.rotation) as Transform;
            splosion = Instantiate(spexplosion, transform.position, transform.rotation) as Transform;
            splosion = Instantiate(spexplosion, transform.position, transform.rotation) as Transform;
            splosion = Instantiate(spexplosion, transform.position, transform.rotation) as Transform;
            splosion = Instantiate(spexplosion, transform.position, transform.rotation) as Transform;
            
            Destroy(transform.parent.gameObject);
        }
        else
        {
            fairyLife = fairyLife - 1;
        }
    }

	void OnTriggerStay(Collider other)
    {	
		if(other.GetComponent<Collider>().gameObject.tag=="LineOf")
        {
            HitStart();
        }
	}

}
