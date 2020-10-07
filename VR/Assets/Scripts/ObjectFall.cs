using System.Collections;
using UnityEngine;

public class ObjectFall : ObjectBase
{
    private Rigidbody rig;

    protected override void Awake()
    {
        base.Awake();

        rig = GetComponent<Rigidbody>();
    }

    protected override IEnumerator Action()
    {
        aud.PlayOneShot(sound, volume);
        rig.useGravity = true;                            // 啟用動力

        yield return new WaitForSeconds(delay);           // 延遲

        aud.enabled = false;                              // 喇叭 啟動 = 否     
    }
}
