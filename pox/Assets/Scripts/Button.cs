using UnityEngine;
/*** A script on a child of player character
* It should have a small BoxCollider2D set to trigger to just touch the ground
***/
public class Button : MonoBehaviour
{
    public bool pressed;
    public BoxCollider2D collider;
    public void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    
        
    }
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pressed = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressed = false;
    }


}