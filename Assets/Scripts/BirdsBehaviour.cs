using UnityEngine;

public class BirdsBehaviour : MonoBehaviour
{

	public Transform birdsPrefab;
	float birdTimer;
	
	void Start()
	{
		birdTimer = Random.Range(2,5);
	}
	
	void Update()
	{
		if(birdTimer < Time.time)
		{
			StartBirds();
		}
	}
	
	void StartBirds()
	{
		Transform birds = (Transform)Instantiate(birdsPrefab, transform.position, transform.rotation);		
		birdTimer = Time.time + Random.Range(5,20);
	}
}
