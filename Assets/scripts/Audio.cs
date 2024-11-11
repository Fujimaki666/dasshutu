using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    // 音を格納する変数
    public AudioClip clickSound;

    // 一度だけ再生するためのフラグ
    private bool hasPlayed = false;

    // クリックが検出されたときに呼ばれるメソッド
    private void OnMouseDown()
    {
        // まだ音が再生されていない場合
        if (!hasPlayed)
        {
            // 音を再生する
            AudioSource.PlayClipAtPoint(clickSound, transform.position);
            // 再生フラグを設定する
            hasPlayed = true;
        }
    }
}
