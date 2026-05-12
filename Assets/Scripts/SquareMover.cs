using UnityEngine;

public class SquareMover : MonoBehaviour
{

    //public varaible goes here 
    public float speed = 0.02f;
    //xMax
    //xMin
    public float xMax;
    public float xMin; 
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

         
        
        //turn this object red
        //We can get acess ti the transform component by the typing "transform" 
        //on the transform we can access the position which is a vector 3 
        //vector 3 contains x y and z vakyes griuped together

        //not a varabile, so it can't return the value of changing 

        //transfrom.psoition.x += 1f; this is the error version (with out the varaible) 

        


    }

    // Update is called once per frame
    void Update()
    {
        //turn this object to a random color 
        Vector3 newPosition = transform.position;

        //When assigning a value to a float, we want to append "f" to the end
        newPosition.x += speed * Time.deltaTime;//
        transform.position = newPosition;

        //xMax
        if (newPosition.x > xMax)
        {
            //OPTION 1:
            speed *= -1f;

            //OPTION 2:
            //speed = -speed;
        }

        //xMin 
        if (newPosition.x < xMin)
        {
            speed *= -1f;

        }




    }
}
