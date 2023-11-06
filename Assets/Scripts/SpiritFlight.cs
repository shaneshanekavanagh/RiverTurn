using UnityEngine;

public class SpiritFlight : MonoBehaviour
{
    public Transform target;
    public Transform myTransform;
    public Transform explosion;

    private float moveSpeed;
    private float rotationSpeed;
    private float randomFloat;
    private float randomMFloat;
    public float dist;    

    private bool distBool;
    public bool GotHitbool;

    void Awake()
    {
        myTransform = transform;
        // moveSpeed = 10;
        // rotationSpeed = 10;
        // moveSpeed = 10;
        // rotationSpeed = 10;
        randomFloat = Random.Range(8.0F, 12.0F);
        randomMFloat = Random.Range(8.0F, 12.0F);
        rotationSpeed = randomFloat;
        moveSpeed = randomFloat;
    }

    void Start()
    {
        target = GameObject.FindWithTag("outofsight").transform;
    }

    void LateUpdate()
    {
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        
        dist = Vector3.Distance(target.position, transform.position);

        if (dist < 1)
        {
            distBool = true;
            //Destroy(gameObject);
        }

        if (distBool == true)
        {
            if (dist > 2)
            {
                //target = GameObject.FindWithTag("birdiet").transform;
                moveSpeed = 100;
                rotationSpeed = 0;
                distBool = false;
            }
        }

        if (dist > 300)
        {
            rotationSpeed = randomFloat;
            moveSpeed = randomMFloat;
        }
    }
}
