﻿'''<Summary>The WorkerNavigator interface represents a subset of the Navigator interface allowed to be accessed from a Worker. Such an object is initialized for each worker and is available via the WorkerGlobalScope.navigator property obtained by calling window.self.navigator.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [WorkerNavigator]
  '''<Summary>Provides a NetworkInformation object containing information about the network connection of a device.</Summary>
  ReadOnly Property [connection] As Dynamic
End Interface