﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public int speed = 10;

    public float lifeTime = 5;

    // 攻撃力
    public int power = 1;

    void Start() {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

        Destroy(gameObject, lifeTime);
    }
}
