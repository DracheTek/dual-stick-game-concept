using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dualstick_shooter_concept
{
    /// <summary>
    /// 精灵图的基类。二维游戏都从精灵图开始。
    /// 目前精灵图主要分四类：玩家，靶子，投射物
    /// </summary>
    class Sprite
    {
        private Bitmap icon;
        public Point pos;
        public float azimuth;
        public Sprite()
        {

        }
        public void Instantiate()
        {

        }
        public void Destroy()
        {

        }
        /// <summary>
        /// Unity的Update分了多个阶段（Update，LateUpdate，FixedUpdate等）用来对应多种不同的情况
        /// </summary>
        public void OnUpdate()
        {

        }
    }
    
    /// <summary>
    /// 
    /// 召唤物bd的举例
    /// 召唤物用自己的武器攻击
    /// 召唤物用玩家武器的某种劣化版攻击
    /// 召唤物生命为0时自爆
    /// 召唤物定时/按命令/接近触发
    /// 
    /// </summary>

    class PlayerSprite:Sprite
    {
        //public float azimuth;
        //public 
    }

    class TargetSprite:Sprite
    {

    }
    /// <summary>
    /// 给投射物做哪些机制会好玩，很考验游戏经验。
    /// 列举一些常见的机制
    /// 直射：飞行出去，给路过的靶子造成伤害
    /// -投射物慢还是快
    /// -投射物判定点大还是小
    /// 抛射：只在鼠标所在位置造成伤害。通常搭配范围伤害。通常有个延迟
    /// 爆炸：朴实的范围伤害
    /// -圆形范围/扇形范围
    /// 制导：投射物向靶子修正
    /// 多重投射：发射点射出多个投射物，沿固定角度分布。
    /// -投射物的集中与分散
    /// 连锁：投射物击中一个目标后跳到下一个目标
    /// 弹幕：“爆炸开火”机制。透支将来一段时间的攻速，换取一段瞬间爆发伤害
    /// </summary>
    class Projectile:Sprite
    {

    }
}
