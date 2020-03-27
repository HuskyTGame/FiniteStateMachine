/****************************************************
	文件：HunterPatrolState.cs
	作者：HuskyT
	邮箱：1005240602@qq.com
	日期：2020/3/20 18:38:0
	功能：
*****************************************************/

using System;
using UnityEngine;

namespace FiniteStateMachine.Example1
{
    public class HunterPatrolState : StateBase
    {
        protected override void AddActions()
        {
            mActions.Add(new PatrolAction());
            Debug.LogFormat("{0}的Action添加完毕", this);
        }
    }
}
