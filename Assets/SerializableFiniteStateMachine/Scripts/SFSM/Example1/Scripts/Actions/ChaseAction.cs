/****************************************************
	文件：ChaseAction.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 23:51:1
	功能：追逐 Action
*****************************************************/

using System;
using UnityEngine;

namespace SerializableFiniteStateMachine.Example1
{
    [CreateAssetMenu(fileName = "ChaseAction", menuName = "SerializableFiniteStateMachine/Actions/ChaseAction")]
    public class ChaseAction : ActionBase
    {
        public override void Act(StateController controller)
        {
            Chase(controller);
        }
        private void Chase(StateController controller)
        {
            //追逐逻辑
        }
    }
}
