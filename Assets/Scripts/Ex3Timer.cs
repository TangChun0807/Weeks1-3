using UnityEngine;

public class Ex3Timer : MonoBehaviour
{

    public AnimationCurve curve;
   
    public float speed;
    public float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position;
        newPosition.y = curve.Evaluate(timer);
        transform.position = newPosition;
        timer += speed * Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;

        }
    }
}
