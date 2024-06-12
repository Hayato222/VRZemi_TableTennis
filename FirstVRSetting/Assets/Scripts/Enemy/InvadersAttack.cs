using System.Collections;
using System.Collections.Generic;
using ObjectTarget;
using UnityEngine;

public class InvadersAttack : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float power = 0.01f;
    [SerializeField] private int attackFrequency = 5;
    public InvadersAttackSE se;
    public GameManager game;

    void Start()
    {
        StartCoroutine(RandomAttackLoop());
    }

    IEnumerator RandomAttackLoop()
    {
        while (true)
        {
            if (game.inPlay)
            {
                int rand = OrAttackNumber();
                if (rand == 1)
                {
                    GameObject ball;
                    Rigidbody ballRigidbody;

                    ball = Instantiate(ballPrefab, SpawnPoint.position, Quaternion.identity);

                    ballRigidbody = ball.GetComponent<Rigidbody>();

                    ballRigidbody.AddForce(new Vector3(power, 0f, 0f), ForceMode.Impulse);

                    se.shotSE();

                    Debug.Log("攻撃！！！");
                }

                yield return new WaitForSeconds(attackFrequency);
            }
        }
    }

    int OrAttackNumber()
    {
        //1/attackFrequencyの確率で攻撃する
        int rand = Random.Range(1, attackFrequency);
        return rand;
    }
}