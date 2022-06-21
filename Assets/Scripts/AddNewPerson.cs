using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AddNewPerson : Window
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void SelfOpen(Transform position)
    {
        Instantiate(this, position);
    }

    protected override void SelfClose()
    {
        Destroy(this.gameObject);
    }
}
