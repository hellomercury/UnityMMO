﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NetPackageTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(NetPackageType));
		L.RegVar("BaseLine", get_BaseLine, null);
		L.RegVar("BaseHead", get_BaseHead, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<NetPackageType>.Check = CheckType;
		StackTraits<NetPackageType>.Push = Push;
	}

	static void Push(IntPtr L, NetPackageType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(NetPackageType), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BaseLine(IntPtr L)
	{
		ToLua.Push(L, NetPackageType.BaseLine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BaseHead(IntPtr L)
	{
		ToLua.Push(L, NetPackageType.BaseHead);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		NetPackageType o = (NetPackageType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}
