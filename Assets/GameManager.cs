using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Ballのプレハブが格納される配列
    public GameObject[] ballPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        // Ballの落下開始
        StartCoroutine("DropBall");
    }
    private IEnumerator DropBall()
    {
        for (int i = 0; i < 50; i++)
        {
            // 生成されるボールの種類の乱数
            int RANDOM_INDEX = Random.Range(0, ballPrefabs.Length);
            // ボールが生成されるx座標の乱数
            float RANDOM_X = Random.Range(-2.0f, 2.0f);
            // ボールが生成される座標のVector
            Vector3 BALL_INITIAL_POSITION = new Vector3(RANDOM_X, 7.0f, 0.0f);
            // ボールの生成
            GameObject clonedBall = Instantiate(ballPrefabs[RANDOM_INDEX]);

            // ボールの座標を設定
            clonedBall.transform.position = BALL_INITIAL_POSITION;

            // 次のボールの生成まで待機
            yield return new WaitForSeconds(0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
