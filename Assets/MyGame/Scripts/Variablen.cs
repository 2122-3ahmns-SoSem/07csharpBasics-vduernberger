using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    Color farbe;
    indexer anzTueren;
    bool fahren;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " + Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
