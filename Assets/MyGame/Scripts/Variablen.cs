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
    int anzTueren;
    int anzTueren2;
    int anzTueren3;
    bool fahren;
    string name;

    //Ich habe gemeinsam Laura Forsthuber und Sophe Kloiber gearbeitet :)

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " + Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);

        //man kann beispielsweise Variablen nutzen, um bestimmte Personen anzusprechen:
        name = "Frau Meerwald-Stadler"; 
        Debug.Log("Hallo " + name);

        //eine weitere Anwendungsfunktion wäre beispielsweise, um Werte zu berechnen:
        anzTueren = 5;
        anzTueren2 = 6;
        anzTueren3 = 7;
        Debug.Log(anzTueren + anzTueren2 + anzTueren3);

        //man kann durch Variablem auch die Farbe von Objekten ändern:
        farbe = Color.red;
        Debug.Log(farbe);
        gameObject.GetComponent<Renderer>().material.color = farbe;

        //Man kann auch Werte vergleichen lassen, also hier beispielsweise ob anzTueren größer ist als anzTueren2
        Debug.Log(anzTueren < anzTueren2);
    }

}
