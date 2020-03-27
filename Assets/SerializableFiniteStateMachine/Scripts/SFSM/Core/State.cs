/****************************************************
	文件：State.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 22:8:17
	功能：状态
*****************************************************/

using UnityEngine;

namespace SerializableFiniteStateMachine
{
    /*
     * 状态
     * 可创建不同 AI 对象特有的状态，可序列化为 Asset 资产对象，便于在 Unity 编辑模式下配置 AI
     * 作用：划分 AI 状态（内部处理每个状态独有的逻辑）
     */
    [CreateAssetMenu(fileName = "DefaultState", menuName = "SerializableFiniteStateMachine/States")]
    public class State : ScriptableObject
    {
        [Tooltip("该状态下的行动集合")]
        public ActionBase[] Actions;
        [Tooltip("该状态下的转换条件集合")]
        public Transition[] Transitions;

        public void UpdateState(StateController controller)
        {
            DoActions(controller);
            CheckTransitions(controller);
        }

        private void DoActions(StateController controller)
        {
            for (int i = 0; i < Actions.Length; i++)
            {
                Actions[i].Act(controller);
            }
        }
        private void CheckTransitions(StateController controller)
        {
            bool succeed = false;
            //每次帧循环都会检测当前状态所有的转换条件
            //若存在多个转换条件，且同时为 TrueState 时，选取最后一个 TrueState 为成功转换的状态（此处可以修改选取规则）
            for (int i = 0; i < Transitions.Length; i++)
            {
                succeed = Transitions[i].Decision.Decide(controller);
                if (succeed)
                {
                    controller.TransitionToState(Transitions[i].TrueState);
                }
                else
                {
                    controller.TransitionToState(Transitions[i].FalseState);
                }
            }
        }
    }
}
