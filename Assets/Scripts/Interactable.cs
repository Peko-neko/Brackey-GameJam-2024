using UnityEngine;
public class Interactable : MonoBehaviour
{
    public virtual void Interact()
    {
        // Override this method for specific interactions
        Debug.Log("Interacted with " + gameObject.name);
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
    }
}
