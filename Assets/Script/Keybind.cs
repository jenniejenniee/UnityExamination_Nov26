using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
    
public class Keybind : MonoBehaviour
{
    public InputActionAsset JennieInputAction;
    public UnityEvent JennieEvent;
        

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JennieInputAction.FindAction("Move").IsPressed())
        {
            JennieEvent.Invoke();
        }
    }
}
