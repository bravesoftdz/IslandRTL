﻿'''<Summary>The ShadowRoot interface of the Shadow DOM API is the root node of a DOM subtree that is rendered separately from a document's main DOM tree.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [ShadowRoot]
'Defined on this type 
  '''<Summary>Returns a reference to the DOM element the ShadowRoot is attached to.</Summary>
  ReadOnly Property [host] As Element
  '''<Summary>The mode of the ShadowRoot — either open or closed. This defines whether or not the shadow root's internal features are accessible from JavaScript.</Summary>
  ReadOnly Property [mode] As Dynamic
  '''<Summary>Returns the topmost element at the specified coordinates.</Summary>
  Sub [elementFromPoint]([parx] As Dynamic, [pary] As Dynamic)
End Interface