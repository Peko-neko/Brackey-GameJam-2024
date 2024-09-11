using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 2f; // Range for interacting
    private Interactable interactableObject;

    // Key code for interaction; change this if needed
    public KeyCode interactionKey = KeyCode.Return;

    // Time required to hold the key before interaction occurs
    public float holdDuration = 2f;

    private float holdTimer = 0f; // Timer to keep track of how long the key has been held


    //NOTE : If you want to add events BETWEEN the holding button (showing animations or somethin) add then in void Update()
    void Update()
    {
        if (Input.GetKey(interactionKey))
        {
            // Increment the hold timer while the key is held
            holdTimer += Time.deltaTime;

            // Check if the key has been held for the required duration
            if (holdTimer >= holdDuration)
            {
                if (interactableObject != null)
                {
                    interactableObject.Interact();
                    // Optionally reset the timer if you want to allow multiple interactions
                    holdTimer = 0f;
                }
            }
        }
        else
        {
            // Reset the timer if the key is not being held
            holdTimer = 0f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Interactable interactable = other.GetComponent<Interactable>();
        if (interactable != null)
        {
            interactableObject = interactable;
            Debug.Log("In range to interact with " + interactable.gameObject.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Interactable>() == interactableObject)
        {
            interactableObject = null;
            Debug.Log("Out of range.");
        }
    }
}
