using UnityEngine;

public class Balloon : MonoBehaviour
{
    // 振幅
    private float _amplitude;

    // 周期
    private float _period;

    // 位相
    private float _phase;

    // 動かす軸
    private enum Axis
    {
        X,
        //Y,
        Z
    }

    [SerializeField] private Axis _axis;

    private Transform _transform;
    private Vector3 _initPosition;
    private Vector3 pos;
    private Rigidbody rigid;

    // 初期化
    private void Start()
    {
        _amplitude = Random.Range(0.4f, 0.6f);
        _period = Random.Range(4.0f, 6.0f);
        _phase = Random.Range(0.0f, 1.0f);

        rigid = GetComponent<Rigidbody>();
        //pos = transform.position;
        _transform = transform;
        _initPosition = _transform.localPosition;
    }

    private void Update()
    {
        // 周期と位相を考慮した現在時間計算
        var t = 4 * _amplitude * (Time.time / _period + _phase + 0.25f);

        // 往復した値を計算
        var value = Mathf.PingPong(t, 2 * _amplitude) - _amplitude;

        // 変位計算
        var changePos = Vector3.zero;

        switch (_axis)
        {
            case Axis.X:
                changePos.x = value;
                break;
            /*case Axis.Y:
                changePos.y = value;
                break;*/
            case Axis.Z:
                changePos.z = value;
                break;
        }

        // 位置を反映
        _transform.localPosition = _initPosition + changePos;
        _initPosition.y += 0.03f;
    }

    /*void FixedUpdate(){
        pos.y += 0.01f;
    }*/
}