﻿using Microsoft.JSInterop;

namespace NewTabApp.Services;

public class JsConsoleService
{
	private readonly IJSRuntime _jsRuntime;

	public JsConsoleService(IJSRuntime jSRuntime)
	{
		_jsRuntime = jSRuntime;
	}

	public async Task LogToConsole(object? obj)
	{
		await _jsRuntime.InvokeVoidAsync("console.log", obj);
	}
}