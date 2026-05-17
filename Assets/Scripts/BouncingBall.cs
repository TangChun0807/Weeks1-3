using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public float yMin;
    public float yMax;
    public float xMin;
    public float xMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //turn this object to a random color 
        Vector3 newPosition = transform.position;

        //When assigning a value to a float, we want to append "f" to the end
        newPosition.x += xSpeed * Time.deltaTime;//
        newPosition.y += ySpeed * Time.deltaTime;
        transform.position = newPosition;

        //xMax
        if (newPosition.x > xMax)
        {
            //OPTION 1:
            xSpeed *= -1f;

            
        }

        //xMin 
        if (newPosition.x < xMin)
        {
            xSpeed *= -1f;

        }

        //yMax
        if(newPosition.y > yMax)
        {
            ySpeed *= -1f;
        }
        //yMin
        if(newPosition.y < yMin)
        {
            ySpeed *= -1f;
        }
    }
}
