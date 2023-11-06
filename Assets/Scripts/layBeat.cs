using UnityEngine;

public class layBeat : MonoBehaviour {

	public AudioClip beat1;
	public AudioClip beat2;
	public AudioClip beat3;

	void Start ()
    {	
	    Invoke("playBeat", 1.0f);
	    InvokeRepeating("playBeat3",1.0f,4.0f);
		
	    InvokeRepeating("playBeat3",12.5f,12.0f);
	    InvokeRepeating("playBeat3",13.5f,12.0f);
		
	    InvokeRepeating("playBeat6",25f,2.0f);
	    InvokeRepeating("playBeat6",33f,1.0f);
	}	
	
	void playBeat()
    {
		Invoke("playBeat1", 1.0f);
	}
	
	void playBeat1()
    {
		GetComponent<AudioSource>().PlayOneShot(beat1);
		Invoke("playBeat2", 0.5f);
	}
	
	void playBeat2()
    {
		GetComponent<AudioSource>().PlayOneShot(beat2);
		Invoke("playBeat1", 0.5f);		
	}
	
	void playBeat3()
    {
		GetComponent<AudioSource>().PlayOneShot(beat2);
		Invoke("playBeat4", 0.1f);
		Invoke("playBeat4", 0.15f);
		Invoke("playBeat4", 0.2f);
		Invoke("playBeat4", 0.25f);
		Invoke("playBeat5", 0.075f);
		Invoke("playBeat5", 0.125f);
		Invoke("playBeat5", 0.175f);
		Invoke("playBeat5", 0.225f);
	}
	
	void playBeat4()
    {
		GetComponent<AudioSource>().PlayOneShot(beat1);
	}
	
	void playBeat5()
    {
		GetComponent<AudioSource>().PlayOneShot(beat2);
	}
	
	void playBeat6()
    {
		Invoke("playBeat4", 0.1f);
		Invoke("playBeat4", 0.15f);
		Invoke("playBeat4", 0.2f);
		Invoke("playBeat4", 0.25f);
		Invoke("playBeat4", 0.075f);
		Invoke("playBeat4", 0.125f);
		Invoke("playBeat4", 0.175f);
		Invoke("playBeat4", 0.225f);
	}

    void playBeat7()
    {
		Invoke("playBeat5", 0.11f);
		Invoke("playBeat5", 0.16f);
		Invoke("playBeat5", 0.21f);
		Invoke("playBeat5", 0.26f);
		Invoke("playBeat5", 0.085f);
		Invoke("playBeat5", 0.135f);
		Invoke("playBeat5", 0.185f);
		Invoke("playBeat5", 0.235f);
	}
}
