/****************************************************
	文件：PatrolAction.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 23:44:27
	功能：巡逻 Action
*****************************************************/

using System;
using UnityEngine;

namespace SerializableFiniteStateMachine.Example1
{
    [CreateAssetMenu(fileName = "PatrolAction", menuName = "SerializableFiniteStateMachine/Actions/PatrolAction")]
    public class PatrolAction : ActionBase
    {
        public override void Act(StateController controller)
        {
            Patrol(controller);
        }
        private void Patrol(StateController controller)
        {
            //巡逻逻辑
        }
    }
}
