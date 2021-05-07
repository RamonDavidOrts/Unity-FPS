using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    [SerializeField] Transform objetivo;
    NavMeshAgent agente;
    float velocidad = 2;
    float distanciaCambio = 0.2f;
    byte siguientePosicion = 0;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agente.SetDestination(objetivo.position);
    }
}
