using UnityEngine;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    public GameObject panneauUI;
    public TextMeshProUGUI texteInfo;
    public string description = "Composant OK";

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab;

    void Start()
    {
        panneauUI.SetActive(false);
        grab = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
        grab.hoverEntered.AddListener(OnHover);
        grab.hoverExited.AddListener(OnHoverExit);
    }

    void OnHover(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args)
    {
        panneauUI.SetActive(true);
        texteInfo.text = description;
    }

    void OnHoverExit(UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs args)
    {
        panneauUI.SetActive(false);
    }
}