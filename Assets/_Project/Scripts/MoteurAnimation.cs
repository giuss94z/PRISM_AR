using UnityEngine;

public class MoteurAnimation : MonoBehaviour
{
    public float vitesseRotation = 90f;
    private bool enMarche = false;

    public void DemarrerMoteur()
    {
        enMarche = !enMarche;
    }

    void Update()
    {
        if (enMarche)
        {
            transform.Rotate(Vector3.up, vitesseRotation * Time.deltaTime);
        }
    }
}