using UnityEngine;

public class TP : MonoBehaviour
{
    public float durations;
    float progress = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        if(progress >= durations)
        {
            transform.position = new Vector3(Random.value, Random.value);
            progress = 0f;

            
        }
    }
}
