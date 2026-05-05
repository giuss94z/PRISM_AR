using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiagnosticManager : MonoBehaviour
{
    [Header("Pièces à inspecter")]
    public List<GameObject> pieces;

    [Header("UI")]
    public TextMeshProUGUI scoreText;

    private int piecesInspectees = 0;

    public void PieceInspectee()
    {
        piecesInspectees++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Pièces inspectées : "
                           + piecesInspectees
                           + " / " + pieces.Count;
    }

    public void ResetDiagnostic()
    {
        piecesInspectees = 0;
        UpdateUI();
    }
}