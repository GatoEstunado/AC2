using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public enum EnumEnemyState
{
    RECUAR,
    PROCURAR,
    PERSEGUIR,
    SEGUIR,
    FUGIR
}

public class EnemyState : MonoBehaviour
{
    public EnumEnemyState state;

    public Wander wander;
    public Seek seek;
    public SeekHard seekHard;
    public Flee flee;
    public Arrive arrive;

    public LayerMask layer;

    void Start()
    {
        state = EnumEnemyState.PROCURAR;
        ChangeState(EnumEnemyState.PROCURAR);
    }

    void Update()
    {
        switch (state)
        {
            case EnumEnemyState.PROCURAR:
                if (GameManager.Instance.scareEnemies == true)
                {
                    Debug.Log("Entrou no if item");
                    ChangeState(EnumEnemyState.FUGIR);
                    break;
                }

                var collider = Physics2D.OverlapCircle(transform.position, 2.5f, layer);

                if (collider.CompareTag("Player"))
                {
                    ChangeState(EnumEnemyState.PERSEGUIR);
                    Gizmos.color = Color.red;
                }
                break;

            case EnumEnemyState.RECUAR:
                if (GameManager.Instance.scareEnemies == true)
                {
                    ChangeState(EnumEnemyState.FUGIR);
                }
                break;

            case EnumEnemyState.PERSEGUIR:
                if (GameManager.Instance.scareEnemies == true)
                {
                    ChangeState(EnumEnemyState.FUGIR);
                }   
                break;

            case EnumEnemyState.FUGIR:
                if (GameManager.Instance.scareEnemies == true)
                {
                    ChangeState(EnumEnemyState.FUGIR);
                    break;
                }                
                break;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 2.5f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (state)
        {
            case EnumEnemyState.FUGIR:
                if (other.collider.CompareTag("Player"))
                {
                    ChangeState(EnumEnemyState.RECUAR);
                }
                break;
        }
    }

    public void ChangeState(EnumEnemyState newState)
    {
        switch (newState)
        {
            case EnumEnemyState.PROCURAR:
                DisableAll();
                wander.enabled = true;
                print("Procurando");
                break;

            case EnumEnemyState.RECUAR:
                DisableAll();
                arrive.enabled = true;
                print("Voltou");
                break;

            case EnumEnemyState.FUGIR:
                DisableAll();
                flee.enabled = true;
                print("Fugindo");
                break;

            case EnumEnemyState.PERSEGUIR:
                DisableAll();
                seek.enabled = true;
                print("Perseguindo");
                break;

            case EnumEnemyState.SEGUIR:
                DisableAll();
                seekHard.enabled = true;
                print("Seguindo");
                break;
        }

        state = newState;
    }

    private void DisableAll()
    {
        wander.enabled = false;
        seek.enabled = false;
        seekHard.enabled = false;
        flee.enabled = false;
        arrive.enabled = false;
    }
}
