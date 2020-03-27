/****************************************************
	文件：StateController.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 22:6:21
	功能：状态管理器（AI Brain）
*****************************************************/

using System;
using UnityEngine;

namespace SerializableFiniteStateMachine
{
    /*
     * 状态管理器
     * AI Brain，直接挂载在 NPC 上
     * 作用：AI 的状态控制器（核心类）
     */
    public class StateController : MonoBehaviour
    {
        [Tooltip("当前状态")]
        public State CurrentState;
        [Tooltip("预设的虚拟状态")]
        public State RemainState;

        /// <summary>
        /// AI 是否为激活状态
        /// </summary>
        private bool mAIActivate = false;
        /// <summary>
        /// 当前状态过去的时间（当前状态的计时器）
        /// </summary>
        private float mElapsedTime = 0.0f;

        public void SetupAI(bool aiActivate, params object[] args)
        {
            mAIActivate = aiActivate;
            //设置 AI 数据
        }
        private void Update()
        {
            if (mAIActivate == false) return;
            CurrentState.UpdateState(this);
        }
        public void TransitionToState(State targetState)
        {
            if (targetState == RemainState) return;
            CurrentState = targetState;
            OnExitState();
        }
        /// <summary>
        /// 检测当前状态的计时器是否到达指定时间
        /// </summary>
        /// <param 指定时间="time"></param>
        /// <returns></returns>
        public bool CheckElapsedTime(float time)
        {
            mElapsedTime += Time.deltaTime;
            return mElapsedTime >= time;
        }
        private void OnExitState()
        {
            mElapsedTime = 0.0f;//计时器清零
        }
    }
}
