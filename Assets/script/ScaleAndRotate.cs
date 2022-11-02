using UnityEngine;
using System.Collections;


public class ScaleAndRotate : MonoBehaviour
{
    private Touch oldTouch1;  //上次觸摸點1(手指1)
    private Touch oldTouch2;  //上次觸摸點2(手指2)
    void Update()
    {
        //Debug.Log("transform.localEulerAngles = " + transform.localEulerAngles);

        //沒有觸摸，就是觸摸點為0
            if (Input.touchCount <= 0)
        {
            return;
        }
        //單點觸摸， 水平上下旋轉
        if (1 == Input.touchCount)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 deltaPos = touch.deltaPosition;
            // if((Vector3.down * deltaPos.x).y < 180f && (Vector3.down * deltaPos.x).y > -180f)
                transform.Rotate(Vector3.down * deltaPos.x, Space.World);//繞Y軸進行旋轉
            // if((Vector3.right * deltaPos.y).x < 180f && (Vector3.right * deltaPos.y).x > -180f)
                transform.Rotate(Vector3.right * deltaPos.y, Space.World);//繞X軸進行旋轉，下面我們還可以寫繞Z軸進行旋轉
        }
        //多點觸摸, 放大縮小
        Touch newTouch1 = Input.GetTouch(0);
        Touch newTouch2 = Input.GetTouch(1);
        //第2點剛開始接觸屏幕, 只記錄，不做處理
        if (newTouch2.phase == TouchPhase.Began)
        {
            oldTouch2 = newTouch2;
            oldTouch1 = newTouch1;
            return;
        }
        //計算老的兩點距離和新的兩點間距離，變大要放大模型，變小要縮放模型
        float oldDistance = Vector2.Distance(oldTouch1.position, oldTouch2.position);
        float newDistance = Vector2.Distance(newTouch1.position, newTouch2.position);

        //兩個距離之差，為正表示放大手勢， 為負表示縮小手勢
        float offset = newDistance - oldDistance;
        //放大因子， 一個像素按0.01倍來算(100可調整) 
        float scaleFactor = offset / 100f;
        Vector3 localScale = transform.localScale;
        Vector3 scale = new Vector3(localScale.x + scaleFactor,
                                    localScale.y + scaleFactor,
                                    localScale.z + scaleFactor);
        //在什麼情況下進行縮放
        //if ((scale.x >= 1f && scale.y >= 1f && scale.z >= 1f) && (scale.x <= 1.5f && scale.y <= 1.5f && scale.z <= 1.5f))
        if (scale.x >= 1f && scale.y >= 1f && scale.z >= 1f)
        {
            transform.localScale = scale;
        }

        //記住最新的觸摸點，下次使用
        oldTouch1 = newTouch1;
        oldTouch2 = newTouch2;


    }
}

