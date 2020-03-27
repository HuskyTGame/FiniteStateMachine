/****************************************************
	文件：StateBase.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 15:55:28
	功能：状态基类
*****************************************************/

using System.Collections.Generic;
using UnityEngine;

namespace FiniteStateMachine
{
    /*
     * 状态基类
     * 可创建不同 AI 对象特有的状态
     * 作用：划分 AI 状态（内部处理每个状态独有的逻辑）
     * 使用：在子类中设置 状态 包含的 动作集Actions ；转换条件集（Transitions）在外部设置
     * 可选：在子类中实现 DoOnBefore 和 DoOnExit （状态 的 生命周期函数）
     */
    public abstract class StateBase
    {
        protected List<ActionBase> mActions;
        protected List<Transition> mTransitions;

        public StateBase()
        {
            mActions = new List<ActionBase>();
            mTransitions = new List<Transition>();
            AddActions();
        }

        public virtual void DoOnBefore(StateController controller) { }
        public virtual void DoOnExit(StateController controller) { }
        /// <summary>
        /// 在子类中配置 状态 State 包含的 动作集（Actions）
        /// </summary>
        protected abstract void AddActions();
        /// <summary>
        /// 在子类中配置 状态 State 包含的 转换条件集（Transitions）
        /// </summary>
        public void AddTransition(Transition transition)
        {
            for (int i = 0; i < mTransitions.Count; i++)
            {
                if (mTransitions[i] == transition)
                {
                    Debug.LogErrorFormat("{0}状态中已包含转换条件：{1}", this, transition.Decision.ToString());
                    return;
                }
            }
            mTransitions.Add(transition);
            Debug.LogFormat("在{0}状态中添加转换条件：{1}", this, transition.Decision.ToString());
        }
        public void UpdateState(StateController controller)
        {
            DoActions(controller);
            CheckTransitions(controller);
        }
        private void DoActions(StateController controller)
        {
            for (int i = 0; i < mActions.Count; i++)
            {
                mActions[i].Act(controller);
            }
        }
        private void CheckTransitions(StateController controller)
        {
            bool succeed = false;
            //每次帧循环都会检测当前状态所有的转换条件
            //若存在多个可以成功转换的 转换条件 时，选取第一个为成功转换的状态（此处可以修改选取规则）
            for (int i = 0; i < mTransitions.Count; i++)
            {
                succeed = mTransitions[i].Decision.Decide(controller);
                if (succeed)
                {
                    controller.TransitionToState(mTransitions[i].TargetState);
                    break;
                }
            }
        }
    }
}
