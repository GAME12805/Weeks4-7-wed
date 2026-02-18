using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;
    void Start()
    {
        
    }

    void Update()
    {
        if(hazard.bounds.Contains(transform.position) == true)
        {
            if(isInHazard == true)
            {
                //still in the hazard
            }
            else
            {
                //entered teh hazard!
                //do something!
                Debug.Log("Entered the sensor!");
                OnEnterSensor.Invoke();
                isInHazard = true;
            } 
        }
        else
        {
            if(isInHazard == true)
            {
                //exited the haxzard!
                //do something
                Debug.Log("Exited the sensor!");
                OnExitSensor.Invoke();
                isInHazard = false;
                OnRandomNumber.Invoke(Random.Range(0, 10));
            }
            else
            {
                //still outside the hazard
            }
        }
    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
