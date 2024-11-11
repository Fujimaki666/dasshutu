using UnityEngine;

public class DoorAnimationHandler : StateMachineBehaviour
{
    private DoorTransitionEffect doorTransitionEffect;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // ドアのトランジション効果を開始
        if (doorTransitionEffect == null)
        {
            // Animator の GameObject から DoorTransitionEffect を探す
            doorTransitionEffect = animator.GetComponent<DoorTransitionEffect>();

            // 親オブジェクトもしくはシーン全体から探す
            if (doorTransitionEffect == null)
            {
                doorTransitionEffect = Camera.main?.GetComponent<DoorTransitionEffect>();
            }
        }

        if (doorTransitionEffect != null)
        {
            doorTransitionEffect.StartDoorTransition();
        }
    }
}
