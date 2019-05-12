using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTLRAviaoDrop : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform SpawnSE;
    public Transform SpawnNE;
    public Transform SpawnSW;
    public Transform SpawnNW;
    public Transform SpawnW;
    public Transform SpawnE;

    public float tempoSpawn;
    public float SpawnAleatorio;
    public GameObject Aviao;
    public bool CTRLSpawn;
    void Start()
    {
        tempoSpawn = 0;
        CTRLSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        tempoSpawn += Time.deltaTime;
        SpawnAleatorio = Random.value;

        // Esquema de Spawn de Avioes

        if (CTRLSpawn)
        {

           

            // condicao 1
            if (SpawnAleatorio >= 0 && SpawnAleatorio < 0.16)
            {
                Instantiate(Aviao, SpawnSE.position, SpawnSE.rotation);

                CTRLSpawn = false;
            }

            // condicao 2
            if (SpawnAleatorio >= 0.16 && SpawnAleatorio < 0.32)
            {
                Instantiate(Aviao, SpawnNE.position, SpawnNE.rotation);
                CTRLSpawn = false;

            }

            // condicao 3
            if (SpawnAleatorio >= 0.32 && SpawnAleatorio < 0.48)
            {
                Instantiate(Aviao, SpawnSW.position, SpawnSW.rotation);

                CTRLSpawn = false;

            }

            // condicao 4
            if (SpawnAleatorio >= 0.48 && SpawnAleatorio < 0.64)
            {
                Instantiate(Aviao, SpawnNW.position, SpawnNW.rotation);
                CTRLSpawn = false;

            }

            // condicao 5
            if (SpawnAleatorio >= 0.64 && SpawnAleatorio < 0.80)
            {
                Instantiate(Aviao, SpawnW.position, SpawnW.rotation);
                CTRLSpawn = false;

            }

            // condicao 6
            if (SpawnAleatorio >= 0.80 && SpawnAleatorio < 1)
            {
                Instantiate(Aviao, SpawnE.position, SpawnE.rotation);

                CTRLSpawn = false;
            }

        }
        if (tempoSpawn > 10.1)
        {
            tempoSpawn = 0;
            CTRLSpawn = true;
        }
    }
    
}
