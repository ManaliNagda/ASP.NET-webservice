Imports System.Web

Imports System.Web.Services

Imports System.Web.Services.Protocols

&#39; To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the

following line.

&#39; &lt;System.Web.Script.Services.ScriptService()&gt; _

&lt;WebService(Namespace:=&quot;http://tempuri.org/&quot;)&gt; _

&lt;WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)&gt; _

&lt;Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()&gt; _

Public Class Service

Inherits System.Web.Services.WebService

&lt;WebMethod()&gt; _

Public Function HelloWorld() As String

Return &quot;Hello World&quot;

End Function

&lt;WebMethod()&gt; _

Public Function FC(ByVal f As Double) As Double

Return (5 / 9) * (f - 32)

End Function

&lt;WebMethod()&gt; _

Public Function CF(ByVal f As Double) As Double

Return (9 / 5) * (f + 32)

End Function

End Class
