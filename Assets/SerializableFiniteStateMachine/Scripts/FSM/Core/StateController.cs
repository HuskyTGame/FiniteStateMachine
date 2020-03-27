/****************************************************
	文件：StateController.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 16:19:33
	功能：状态管理器（AI Brain）
*****************************************************/

using System;
using UnityEngine;

namespace FiniteStateMachine
{
    /*
     * 状态管理器
     * AI Brain
     * 作用：AI 的状态控制器（核心类）
     */
    public class StateController
    {
        private StateBase mCurrentState;
        /// <summary>
        /// AI 是否为激活状态
        /// </summary>
        private bool mAIActivate;
        /// <summary>
        /// 当前状态过去的时间（当前状态的计时器）
        /// </summary>
        private float mElapsedTime;

        public StateController(StateBase originalState, params object[] args)
        {
            mCurrentState = originalState;
            mAIActivate = true;
            mElapsedTime = 0.0f;
            //设置 AI 初始数据

            Debug.Log("AI 初始化完毕");
        }

        public void SetupAI(bool aiActivate, params object[] args)
        {
            mAIActivate = aiActivate;
            //设置 AI 数据
        }

        public void UpdateAI()
        {
            if (mAIActivate == false) return;
            mCurrentState.UpdateState(this);
        }
        public void TransitionToState(StateBase targetState)
        {
            mCurrentState.DoOnExit(this);
            mElapsedTime = 0.0f;//计时器清零
            mCurrentState = targetState;
            mCurrentState.DoOnBefore(this);
        }
        /// <summary>
        /// 检测当前状态的计时器是否到达指定时间
        /// </summary>
        /// <param 指定时间="time"></param>
        /// <returns></returns>
        public bool CheckElapsedTime(float time)
        {
            return mElapsedTime >= time;
        }
    }
}
