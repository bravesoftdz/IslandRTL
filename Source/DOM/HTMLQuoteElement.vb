﻿'''<Summary>The HTMLQuoteElement interface provides special properties and methods (beyond the regular HTMLElement interface it also has available to it by inheritance) for manipulating quoting elements, like &lt;blockquote> and &lt;q>, but not the &lt;cite> element.</Summary>
<DynamicInterface(GetType(EcmaScriptObject))>
Public Interface [HTMLQuoteElement]
Inherits HTMLElement

  '''<Summary>Is a DOMString reflecting the cite HTML attribute, containing a URL for the source of the quotation.</Summary>
  Property [cite] As String
End Interface