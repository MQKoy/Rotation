using UnityEngine;

public class CircleOrbit : MonoBehaviour
{
    public Transform centerPoint; 
    public float orbitSpeed = 50f; 
    private bool isClockwise = true; 
    void Update()
    {
        
        OrbitAround();

        
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            ToggleOrbitDirection();
        }
    }

    void OrbitAround()
    {
        
        float direction = isClockwise ? -1f : 1f;

        
        transform.RotateAround(centerPoint.position, Vector3.forward, direction * orbitSpeed * Time.deltaTime);
    }

    void ToggleOrbitDirection()
    {
        isClockwise = !isClockwise;
    }
}