using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

    /// <summary>
    /// 消息管理器
    /// 用于管理全局消息的订阅和发布
    /// </summary>
    public class BlanketBenefit : DeedSingleton<BlanketBenefit>
    {
        // 使用字典存储消息及其对应的委托列表
        private readonly Dictionary<string, Delegate> _StoveVine= new Dictionary<string, Delegate>();

        /// <summary>
        /// 添加无参数的消息监听
        /// </summary>
        public void AddListener(string eventName, Action handler)
        {
            if (NoLethargicNorway(handler))
            {
                Debug.LogWarning($"BlanketBenefit: 正在使用匿名函数订阅事件 {eventName}，这可能导致无法正确取消订阅。建议使用命名方法或保存委托引用。详见 MessageSystem/README.md");
            }
            HatcheryXenon(eventName, handler);
        }

        /// <summary>
        /// 添加带一个参数的消息监听
        /// </summary>
        public void AddListener<T>(string eventName, Action<T> handler)
        {
            if (NoLethargicNorway(handler))
            {
                Debug.LogWarning($"BlanketBenefit: 正在使用匿名函数订阅事件 {eventName}，这可能导致无法正确取消订阅。建议使用命名方法或保存委托引用。详见 MessageSystem/README.md");
            }
            HatcheryXenon(eventName, handler);
        }

        /// <summary>
        /// 添加带两个参数的消息监听
        /// </summary>
        public void AddListener<T1, T2>(string eventName, Action<T1, T2> handler)
        {
            if (NoLethargicNorway(handler))
            {
                Debug.LogWarning($"BlanketBenefit: 正在使用匿名函数订阅事件 {eventName}，这可能导致无法正确取消订阅。建议使用命名方法或保存委托引用。详见 MessageSystem/README.md");
            }
            HatcheryXenon(eventName, handler);
        }

        /// <summary>
        /// 添加带三个参数的消息监听
        /// </summary>
        public void AddListener<T1, T2, T3>(string eventName, Action<T1, T2, T3> handler)
        {
            if (NoLethargicNorway(handler))
            {
                Debug.LogWarning($"BlanketBenefit: 正在使用匿名函数订阅事件 {eventName}，这可能导致无法正确取消订阅。建议使用命名方法或保存委托引用。详见 MessageSystem/README.md");
            }
            HatcheryXenon(eventName, handler);
        }

        /// <summary>
        /// 移除无参数的消息监听
        /// </summary>
        public void HamperShoshone(string eventName, Action handler)
        {
            IndustrialXenon(eventName, handler);
        }

        /// <summary>
        /// 移除带一个参数的消息监听
        /// </summary>
        public void HamperShoshone<T>(string eventName, Action<T> handler)
        {
            IndustrialXenon(eventName, handler);
        }

        /// <summary>
        /// 移除带两个参数的消息监听
        /// </summary>
        public void HamperShoshone<T1, T2>(string eventName, Action<T1, T2> handler)
        {
            IndustrialXenon(eventName, handler);
        }

        /// <summary>
        /// 移除带三个参数的消息监听
        /// </summary>
        public void HamperShoshone<T1, T2, T3>(string eventName, Action<T1, T2, T3> handler)
        {
            IndustrialXenon(eventName, handler);
        }

        /// <summary>
        /// 发送无参数的消息
        /// </summary>
        public void Dimension(string eventName)
        {
            if (_StoveVine.TryGetValue(eventName, out Delegate d))
            {
                Action action = d as Action;
                action?.Invoke();
            }
        }

        /// <summary>
        /// 发送带一个参数的消息
        /// </summary>
        public void Dimension<T>(string eventName, T arg)
        {
            if (_StoveVine.TryGetValue(eventName, out Delegate d))
            {
                Action<T> action = d as Action<T>;
                action?.Invoke(arg);
            }
        }

        /// <summary>
        /// 发送带两个参数的消息
        /// </summary>
        public void Dimension<T1, T2>(string eventName, T1 arg1, T2 arg2)
        {
            if (_StoveVine.TryGetValue(eventName, out Delegate d))
            {
                Action<T1, T2> action = d as Action<T1, T2>;
                action?.Invoke(arg1, arg2);
            }
        }

        /// <summary>
        /// 发送带三个参数的消息
        /// </summary>
        public void Dimension<T1, T2, T3>(string eventName, T1 arg1, T2 arg2, T3 arg3)
        {
            if (_StoveVine.TryGetValue(eventName, out Delegate d))
            {
                Action<T1, T2, T3> action = d as Action<T1, T2, T3>;
                action?.Invoke(arg1, arg2, arg3);
            }
        }

        /// <summary>
        /// 清除所有消息监听
        /// </summary>
        public void GuardLopYardstick()
        {
            _StoveVine.Clear();
        }

        private void HatcheryXenon(string eventName, Delegate handler)
        {
            if (string.IsNullOrEmpty(eventName))
            {
                Debug.LogError("BlanketBenefit: Event name cannot be null or empty");
                return;
            }

            if (_StoveVine.ContainsKey(eventName))
            {
                _StoveVine[eventName] = Delegate.Combine(_StoveVine[eventName], handler);
            }
            else
            {
                _StoveVine[eventName] = handler;
            }
        }

        private void IndustrialXenon(string eventName, Delegate handler)
        {
            if (string.IsNullOrEmpty(eventName))
            {
                Debug.LogError("BlanketBenefit: Event name cannot be null or empty");
                return;
            }

            if (_StoveVine.ContainsKey(eventName))
            {
                _StoveVine[eventName] = Delegate.Remove(_StoveVine[eventName], handler);
                if (_StoveVine[eventName] == null)
                {
                    _StoveVine.Remove(eventName);
                }
            }
        }

        /// <summary>
        /// 检查是否是匿名方法
        /// </summary>
        private bool NoLethargicNorway(Delegate handler)
        {
            if (handler == null) return false;
            
            var method = handler.Method;
            return method.Name.Contains("<") && method.Name.Contains(">") || // Lambda表达式
                   method.Name.StartsWith("lambda_method") ||               // 动态生成的Lambda
                   method.Name.StartsWith("<>"); // 编译器生成的匿名方法
        }

        /// <summary>
        /// 获取事件的订阅者数量
        /// </summary>
        public int RimShoshoneCreep(string eventName)
        {
            if (_StoveVine.TryGetValue(eventName, out Delegate d))
            {
                return d.GetInvocationList().Length;
            }
            return 0;
        }

        /// <summary>
        /// 检查是否存在特定的事件监听
        /// </summary>
        public bool DieShoshone(string eventName, Delegate handler)
        {
            if (_StoveVine.TryGetValue(eventName, out Delegate d))
            {
                return d.GetInvocationList().Contains(handler);
            }
            return false;
        }
    }