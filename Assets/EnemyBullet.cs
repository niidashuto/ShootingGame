using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //弾のスピード
    public float speed = 1;
    //自然消滅までのタイマー
    public float time = 2;
    //進行方向
    protected Vector3 forward=
        new Vector3(1,1,1);
    //打ち出すときの角度
    protected Quaternion forwardAxis=
        Quaternion.identity;
    //RigidBody用変数
    protected Rigidbody rb;
    //Enemy用変数
    protected GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //RigidBody変数を初期化
        rb=this.GetComponent<Rigidbody>();

        //生成時に進行方向を決める
        if(enemy!=null)
        {
            forward = enemy.transform.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //移動量を進行方向にスピード分だけ加える
        rb.velocity = forwardAxis * forward * speed;
        //空中に浮かないようにする
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        //時間制限が来たら自然消滅する

    }
    void OnTriggerEnter(Collider other)
    {
        //もし当たったオブジェクトのタグがPlayer or PlayerBodyだったら
        if(other.gameObject.tag=="Player"||other.gameObject.tag=="PlayerBody")
        {
            Destroy(this.gameObject);
        }
    }
}
