// 課題---★
using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    // キューブの移動速度
    private float speed = -0.2f;

       // 消滅位置
    private float deadLine = -10;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);
        //Debug.Log(this.transform.position);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }

    // ★キューブが何かに接触したときに呼ばれる関数
    void OnCollisionEnter2D(Collision2D other)
    {
        GetComponent<AudioSource>().Play();

        if (other.gameObject.tag == "Unitychan")
        {
            GetComponent<AudioSource>().volume = 0;
        }
    }
}
