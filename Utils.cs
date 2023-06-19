using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerForNumber
{
	
	internal static class Utils
	{
		public static bool TryInvoke(this Control control, Action action)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(action); return true;
			}
			else action(); return false;
		}
		public static void AddOne<TKey, TValue>(this IDictionary<TKey, List<TValue>> dictonary, TKey key, TValue value)
			where TKey : struct
		{
			if (!dictonary.TryGetValue(key, out var values)) dictonary.Add(key, values = new());
			values.Add(value);
		}
		public static void RemoveOne<TKey, TValue>(this IDictionary<TKey, List<TValue>> dictonary,TKey key, TValue value)
			where TKey : struct
		{
			if (dictonary.TryGetValue(key, out var values)) values.Remove(value);
		}

		public static int USIToSI(this uint i, short BitLength)
		{
#pragma warning disable CS0675 // 对进行了带符号扩展的操作数使用了按位或运算符
			if (i >> (BitLength - 1) == 0) return (int)(i & BitOperate.MakeBit1s(BitLength));
			else return (int)(i | (BitOperate.MakeBit1s(32 - BitLength) << BitLength));
#pragma warning restore CS0675 // 对进行了带符号扩展的操作数使用了按位或运算符
		}
		public static uint SIToUSI(this int i, short BitLength)
		{
			return (uint)(i & BitOperate.MakeBit1s(BitLength));
		}
	}
}
