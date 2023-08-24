using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using ComputerForNumber.U

namespace ComputerForNumber
{
	public class ComputerForNumber : IEnumerable<int>
	{
		public event Action OnReset;
		public event Action<int> PostValueChanged;
		public static int BitLengthOfL(short L)
		{
			return L * 2 << L;
		}
		public short BitLength { get;private set; }
		public int Length => 1 << BitLength;
		public void Reset(short L)
		{
			this.BitLength = L;
			List = new long[BitLengthOfL(L) / sizeof(long) + 1];
			OnReset?.Invoke();
		}
		public long[] List { get; private set; }
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
		public ComputerForNumber(short L)
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
		{
			Reset(L);
		}
		public int StoreBitSize = sizeof(long) * 8;
		public int this[int i]
		{
			get
			{
				uint I = i.SIToUSI(BitLength);
				long a = (I * BitLength) / StoreBitSize;
				long b = (I * BitLength) % StoreBitSize;
				long c = List[a];
				uint res = (uint)BitOperate.GetBits(c, b, BitLength);
				long d = b + BitLength - StoreBitSize;

				if (d > 0)
				{
					res |= (uint)(BitOperate.GetBits(List[a + 1], 0, d) << (int)(StoreBitSize - b));
				}

				return res.USIToSI(BitLength);
			}
			set
			{
				uint Value = value.SIToUSI(BitLength);
				uint I = i.SIToUSI(BitLength);
				long a = (I * BitLength) / StoreBitSize;
				long b = (I * BitLength) % StoreBitSize;
				List[a] = BitOperate.SetBits(List[a], Value, b, BitLength);
				long d = b + BitLength - StoreBitSize;
				if (d > 0)
				{
					List[a + 1] = BitOperate.SetBits(List[a + 1], Value >> (int)(StoreBitSize - b), 0, d);
				}
				PostValueChanged?.Invoke(i);

			}
		}
		public bool ComputerForNumberFn() {
			int c = this[0];
			if(c==0) return true;
			int p = this[1];
			if (p>>(BitLength-1)==0) {
				int p1 = this[c];
				int p2= this[c+1];
				int v2= this[p2];
				this[p1] = this[p1] - v2;
				//this[this[c]] +=this[this[c + 1]];
			}
			this[1] = -this[1];
			this[0] = this[0] + 2;
			return false;
		}
		public IEnumerator<int> GetEnumerator()
		{
			for (int i = 0; i < Length; ++i) if (this[i] != 0)yield return i;
		}
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
	public class CFNFramework
	{
		public short BitLength => CFN.BitLength;
		public event Action<CFNFrameworkView>? OnNameChanged;
		public event Action<CFNFrameworkView>? OnAdd;
		public event Action<CFNFrameworkView>? OnRemove;

		public class CFNFrameworkView { 
			public readonly CFNFramework cFNFramework;
			readonly int index;
			public int Index=>index;
			string name;
			public string NumName {
				get => name;
				set { name = value; cFNFramework.OnNameChanged?.Invoke(this); }
			}
			public int Value {
				get => cFNFramework.CFN[index];
				set 
				{
					cFNFramework.CFN[index] = value;
				}
			}

			public CFNFrameworkView(CFNFramework cFNFramework, int index, string name)
			{
				this.cFNFramework = cFNFramework;
				this.index = index;
				this.name = name;
			}
		}
		public readonly ComputerForNumber CFN;

		public CFNFramework(short BitLength)
		{
			CFN = new(BitLength);
			CFN.OnReset += CFN_OnReset;
		}

		private void CFN_OnReset()
		{
			IndexToView.Clear();
			NameToView.Clear();
			IndexToName.Clear();
		}

		public readonly SortedDictionary<uint, HashSet<CFNFrameworkView>> IndexToView = new();
		public readonly SortedDictionary<string, CFNFrameworkView> NameToView = new();
		public readonly SortedDictionary<uint, List<string>> IndexToName = new();

		public CFNFrameworkView? AddView(int index, string name)
		{
			if (NameToView.ContainsKey(name)) return null;
			var NewView = new CFNFrameworkView(this,index, name);
			if (!IndexToView.TryGetValue(index.SIToUSI(BitLength), out var views)) IndexToView.Add(index.SIToUSI(BitLength), views = new());
			views.Add(NewView);
			NameToView.Add(name, NewView);
			//Utils.AddOne
			IndexToName.AddOne(index.SIToUSI(BitLength), name);
			OnAdd?.Invoke(NewView);
			return NewView;
		}
		public bool RemoveView(CFNFrameworkView view)
		{
			if (!NameToView.ContainsKey(view.NumName)) return false;
			IndexToView[view.Index.SIToUSI(BitLength)].Remove(view);
			NameToView.Remove(view.NumName);
			IndexToName.RemoveOne(view.Index.SIToUSI(BitLength), view.NumName);
			OnRemove?.Invoke(view);
			return true;
		}



		public string ShowNumber(int v)
		{
			//int v = CFN[index];
			if (IndexToView.TryGetValue(v.SIToUSI(BitLength), out var views))
			{
				StringBuilder s = new StringBuilder(v.ToString());
				if (views.Count == 0) { return s.ToString();}
				//s.Append('(');
				//bool AddDot = false;
				//foreach (var i in views)
				//{
				//	if (!AddDot) { AddDot = true; }
				//	else s.Append(',');
				//	s.Append(i.NumName);
				//}
				//s.Append(')');
				s.Append($"({string.Join(",", from i in views select i.NumName)})");
				return s.ToString();
			}
			else { return v.ToString(); }
		}

		public string CFNToString()
		{
			StringBuilder s = new();
			s.AppendLine($"BitLength:{CFN.BitLength}");
			SortedSet<int> indexs = new SortedSet<int> { 0, 1 };
			foreach (var i in CFN)
			{
				if (CFN[i] != 0)
				{
					indexs.Add(i);
				}
			}
			foreach (var i in NameToView) {
				indexs.Add(i.Value.Index);
			}
			//s.AppendLine($"Count:{indexs.Count}");
			int il = -2;
			foreach (var i in indexs)
			{
				/*
				if(i-il==-1)
					s.AppendLine($":{CFN[i]}{string.Join(',')}");
				else
					s.AppendLine($"{i}:{ShowNumber(i)}");*/
				s.Append('\\');
				if (i - il != 1) s.Append(i);
				if (IndexToName.TryGetValue(i.SIToUSI(BitLength), out var Names))
				{
					s.Append($"({string.Join(",", Names)})");
				}
				s.Append(':');
				if(CFN[i]!=0) s.Append($"{CFN[i]}");
				
				s.AppendLine(";");
				il = i;
			}
			return s.ToString();
		}
		public void SetByString(string s) {
			/*
			var a=Regex.Match(s, @"BitLength:(\d+)\n");
			if(!a.Success) return false;
			a = Regex.Match(s, @"BitLength:(\d+)\n");
			if(!a.Success) return false;
			
			*/
			short BL=-2;
			//int C=-2;
			int LastIndex=-2;
			var a = Regex.Matches(s, @"<(.*?):(.*?)>");
			List<Match> matches = a.Cast<Match>().ToList();
			//matches.Add(Regex.Match(s, @"(.*?):(.*?)$"));
			Dictionary<uint,string> IndexToValue = new();

			Dictionary<string, uint> NameToIndex = new();
			foreach (Match i in matches) {
				switch (i.Groups[1].Value) {
					case "BitLength":
						if (!short.TryParse(i.Groups[2].Value, out BL)) throw new Exception($"{i}  {i.Groups[2].Value} isn't a number");
						if (BL > 32) throw new Exception($"BitLength{BL} needs <32");
						break;
					//case "Count":
					//	if (!int.TryParse(i.Groups[2].Value, out C)) return false;
					//	break;
					default:
						int index;
						List<string> Names=new();
						
							string IndexStr=i.Groups[1].Value;
							var MatchIndexs = Regex.Match(IndexStr, @"(-?\w+)?(?:\(([\w,]*?)\))*" /*@"(\d+)(?:\((\w+)(?:,(\w+))*\))*"*/);
							if (!int.TryParse(MatchIndexs.Groups[1].Value, out index))
							{
								if (MatchIndexs.Groups[1].Value.Length == 0) index = LastIndex + 1;
								else throw new Exception($"{MatchIndexs} in {MatchIndexs.Groups[1]} isn't a number");
							}
							string namesStr = MatchIndexs.Groups[2].Value;
							var c = Regex.Matches(namesStr, @"(\w+)");
							if (c != null)
							{
								foreach (Match match in c.Cast<Match>())
								{
									Names.Add(match.Groups[1].Value);
								}
							}
						
						IndexToValue.Add(index.SIToUSI(BL), i.Groups[2].Value);
						foreach (var n in Names) {
							NameToIndex.Add(n, index.SIToUSI(BL));
						}
						//if (!int.TryParse(i.Groups[1].Value, out int index)) {
						//	if (i.Groups[1].Value.Length == 0) index = LastIndex + 1;
						//	else throw new Exception($"{i} 中 {i.Groups[1]} 不是数字");
						//}
						//string valueS=i.Groups[2].Value;
						//var b = Regex.Match(valueS, @"(-?\w+)?(?:\(([\w,]*?)\))*" /*@"(\d+)(?:\((\w+)(?:,(\w+))*\))*"*/);
						//string valueString= string.Empty;
						//if (!int.TryParse(b.Groups[1].Value, out int value)) {
						//	if (b.Groups[1].Value.Length == 0) value = 0;
						//	else valueString = b.Groups[1].Value;
						//}
						//string nameS=b.Groups[2].Value;
						//var c = Regex.Matches(nameS, @"(\w+)");
						//List<string> names=new();
						//if (c != null) {
						//	foreach (Match match in c.Cast<Match>())
						//	{
						//		names.Add(match.Groups[1].Value);
						//	}
						//}
						//foreach (var n in names)
						//{
						//	NameToIndex.Add(n, index);

						//}
						//if(value!=0)IndexToValue.Add(index, (value, valueString));
						LastIndex = index;
						break;
				}
			}
			if (BL == -2) throw new Exception("BitLength isn't setted");
			CFN.Reset(BL);
			int TryGetValue(string ValueStr) {
				if (!int.TryParse(ValueStr, out int Index))
				{
					if (ValueStr.Length == 0) Index = 0;
					else
					{
						
						if (!NameToIndex.TryGetValue(ValueStr, out uint uIndex))
						{

							throw new Exception($"unknow value {ValueStr}");
						}
						else Index=uIndex.USIToSI(BL);
					}
				}
				return Index;
			}
			foreach (var i in IndexToValue) {
				//int value=i.Value.Item1;
				//if (i.Value.Item2.Length != 0)
				//	if (!NameToIndex.TryGetValue(i.Value.Item2, out value)) throw new Exception($"{i.Value.Item2}不存在");

				string ValueStr = i.Value;
				int value;
				if (!int.TryParse(ValueStr, out value))
				{
					if (ValueStr.Length == 0) value = 0;
					else {
						if (!NameToIndex.TryGetValue(ValueStr, out uint uvalue)) {
							var matchGoto = Regex.Match(ValueStr,@"(\w+)=>(\w+)");
							if (!matchGoto.Success) throw new Exception($"unknow value {ValueStr}");
							int FromIndex = TryGetValue(matchGoto.Groups[1].Value);
							int ToIndex = TryGetValue(matchGoto.Groups[2].Value);
							//ToIndex-2=FromIndex-value
							//value=index-ToIndex+2
							//ToIndex= FromIndex-value+2
							value = FromIndex - ToIndex + 2;
						}
						else value = uvalue.USIToSI(BL);
					}
				}
				//foreach (var j in NameToIndex) {
				//	ValueStr=ValueStr.Replace(j.Key, j.Value.ToString());
				//}

				CFN[i.Key.USIToSI(BL)] = value;
			}
			foreach (var i in NameToIndex) {
				AddView(i.Value.USIToSI(BL), i.Key);
			}
		}
	}
}
