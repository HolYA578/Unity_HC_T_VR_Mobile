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
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(delay);

        aud.PlayOneShot(sound, volume);

        rig.useGravity = true;                            // 啟用動力
    }
}
