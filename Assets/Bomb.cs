using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キーボードのBが押されたら
        if(Input.GetKeyDown(KeyCode.B))
        {
            //タグが同じオブジェクトをすべて取得する
            GameObject[] enemyBulletObjects =
                GameObject.FindGameObjectsWithTag("EnemyBullet");

            //上で取得した全てのオブジェクトを消滅させる
            for(int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i].gameObject);
            }
        }
    }
}
