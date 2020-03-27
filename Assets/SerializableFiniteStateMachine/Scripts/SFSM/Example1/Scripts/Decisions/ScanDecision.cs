/****************************************************
	文件：ScanDecision.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/19 0:22:2
	功能：扫描 转换决策
*****************************************************/

using System;
using UnityEngine;

namespace SerializableFiniteStateMachine.Example1
{
    [CreateAssetMenu(fileName = "ScanDecision", menuName = "SerializableFiniteStateMachine/Decisions/ScanDecision")]
    public class ScanDecision : DecisionBase
    {
        public override bool Decide(StateController controller)
        {
            return Scan(controller);
        }
        private bool Scan(StateController controller)
        {
            //扫描逻辑
            return false;
        }
    }
}
