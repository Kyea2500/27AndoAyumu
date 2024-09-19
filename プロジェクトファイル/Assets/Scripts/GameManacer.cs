using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManacer : MonoBehaviour
{
    [SerializeField] CardController cardPrefab;
    [SerializeField]
    Transform playerHand, EnemyHand,
        playerField, EnemyFiled;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {


        // ��D��1���z��i�����j
        //   Instantiate(cardPrefab, playerHand);

        // ������D��5��
        for (int i = 0; i < 5; i++)
        {
            Instantiate(cardPrefab, playerHand);
        }
        // �G�����l��5��
        for (int i = 0; i < 5; i++)
        {
            Instantiate(cardPrefab, EnemyHand);
        }

        // ��������m�F
        // �����Ƒ���̔ՖʂɃL�����N�^�[�i�J�[�h�j��\��
        // �����F�R�́@����F�Q��
        for (int i = 0; i < 3; i++)
        {
            Instantiate(cardPrefab, playerField);
        }
        for (int i = 0; i < 2; i++)
        {
            Instantiate(cardPrefab, EnemyFiled);
        }

    }
}

