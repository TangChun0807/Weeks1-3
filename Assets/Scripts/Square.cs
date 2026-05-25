
using UnityEngine;
using static UnityEditor.Progress;


public class Square : MonoBehaviour
{
    private Vector3 startPoint = new Vector3(-8f, -4.5f, 0f);
    private Vector3 endPoint = new Vector3(-8f, -0.5f, 0f);
    public static float t;
    public AnimationCurve curve;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = Vector3.Lerp(startPoint, endPoint, t);
        temp.x += curve.Evaluate(t);
        transform.position = temp;

    }
}
