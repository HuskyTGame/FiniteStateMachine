/****************************************************
	文件：AttackAction.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/18 23:51:10
	功能：攻击 Action
*****************************************************/

using System;
using UnityEngine;

namespace SerializableFiniteStateMachine.Example1
{
    [CreateAssetMenu(fileName = "AttackAction", menuName = "SerializableFiniteStateMachine/Actions/AttackAction")]
    public class AttackAction : ActionBase
    {
        public override void Act(StateController controller)
        {
            Attack(controller);
        }
        private void Attack(StateController controller)
        {
            //攻击逻辑
        }
    }
}
