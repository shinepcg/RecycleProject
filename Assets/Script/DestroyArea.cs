using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DestroyArea : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        
        //쓰레기 파괴
        print("[onTriggerEnger" + other.name);
        TrashSpawn.instance.RemoveTrash(other.gameObject);
        Destroy(other.gameObject);


        //MissPoint 감소
        ScoreManager.instance.FailClassify();

    }
}
