/****************************************************
	文件：HunterController.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 18:34:53
	功能：
*****************************************************/

using System;
using UnityEngine;

namespace FiniteStateMachine.Example1
{
	public class HunterController : MonoBehaviour
	{
        private StateController mAI;
		private void Start()
		{
            HunterPatrolState hunterPatrolState = new HunterPatrolState();
            HunterChaseState hunterChaseState = new HunterChaseState();
            hunterPatrolState.AddTransition(new Transition(new LookDecision(), hunterChaseState));
            hunterChaseState.AddTransition(new Transition(new InactiveStateDecision(), hunterPatrolState));
            mAI = new StateController(hunterPatrolState, null);
		}
        private void Update()
        {
            mAI.UpdateAI();
        }
    }
}
