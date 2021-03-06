﻿'''<Summary>The SharedWorkerGlobalScope object (the SharedWorker global scope) is accessible through the self keyword. Some additional global functions, namespaces objects, and constructors, not typically associated with the worker global scope, but available on it, are listed in the JavaScript Reference. See the complete list of functions available to workers.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [SharedWorkerGlobalScope]
  '''<Summary>The name that the SharedWorker was (optionally) given when it was created using the SharedWorker() constructor. This is mainly useful for debugging purposes.</Summary>
  ReadOnly Property [name] As String
  '''<Summary>Is an EventHandler representing the code to be called when the connect event is raised — that is, when a MessagePort connection is opened between the associated SharedWorker and the main thread.</Summary>
  Property [onconnect] As EventListener
  '''<Summary>Imports one or more scripts into the worker's scope. You can specify as many as you'd like, separated by commas. For example: importScripts('foo.js', 'bar.js');</Summary>
  Function [importScripts]() As Dynamic
  '''<Summary>Decodes a string of data which has been encoded using base-64 encoding.</Summary>
  Function [atob]([parencodedData] As Dynamic) As String
  '''<Summary>Creates a base-64 encoded ASCII string from a string of binary data.</Summary>
  Function [btoa]([parstringToEncode] As Dynamic) As String
  '''<Summary>Cancels the repeated execution set using WindowTimers.setInterval().</Summary>
  Function [clearInterval]([parintervalID] As Dynamic) As Dynamic
  '''<Summary>Cancels the repeated execution set using WindowTimers.setTimeout().</Summary>
  Function [clearTimeout]([partimeoutID] As Dynamic) As Dynamic
  '''<Summary>Schedules the execution of a function every X milliseconds.</Summary>
  Function [setInterval]([parfunc] As Dynamic, [parcode] As Dynamic, [pardelay] As Dynamic, ParamArray args() As Dynamic) As Long
  '''<Summary>Sets a delay for executing a function.</Summary>
  Function [setTimeout]([parfunction] As Dynamic, [parcode] As Dynamic, [pardelay] As Dynamic, [pararg1] As Dynamic) As Dynamic
End Interface