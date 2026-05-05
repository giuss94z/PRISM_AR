using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PieceInteractable : MonoBehaviour
{
    public DiagnosticManager manager;
    private bool inspectee = false;

    void Start()
    {
        XRGrabInteractable grab = GetComponent<XRGrabInteractable>();
        if (grab != null)
            grab.selectEntered.AddListener(OnGrab);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (!inspectee)
        {
            inspectee = true;
            manager.PieceInspectee();
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}