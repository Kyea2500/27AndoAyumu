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


        // 手札を1枚配る（自分）
        //   Instantiate(cardPrefab, playerHand);

        // 初期手札は5枚
        for (int i = 0; i < 5; i++)
        {
            Instantiate(cardPrefab, playerHand);
        }
        // 敵も同様に5枚
        for (int i = 0; i < 5; i++)
        {
            Instantiate(cardPrefab, EnemyHand);
        }

        // いったん確認
        // 自分と相手の盤面にキャラクター（カード）を表示
        // 自分：３体　相手：２体
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

