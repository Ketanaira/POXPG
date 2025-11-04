using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour
{
    public Animator anim;
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {

        btn = GetComponent<Button>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (btn.pressed) {
            anim.SetTrigger("open");
        }
    }
}
