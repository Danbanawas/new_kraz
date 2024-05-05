using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class physics_button : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    private bool inpressed, inreleased;
    private Vector3 startpos;
    private ConfigurableJoint joint;

    public UnityEvent onPressed, onReleased;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.localPosition;
        joint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inpressed && GetValue() + threshold >= 1)
        {
            Pressed();
        }

        if (inpressed && GetValue() - threshold < 1)
        {
            Released();
        }
    }

    private float GetValue()
    {
        var value = Vector3.Distance(startpos, transform.localPosition) / joint.linearLimit.limit;

        if (Mathf.Abs(value) < deadZone)
        {
            value = 0;
        }

        return Mathf.Clamp(value, -1, 1);
    }

    private void Pressed()
    {
        inpressed = true;
        onPressed.Invoke();
    }

    private void Released()
    {
        inpressed = false;
        onReleased.Invoke();
    }
}